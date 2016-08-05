using DataLayer;
using Entity.Queries;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerMetricsWinForms
{
    public partial class ComputerMetricsForm : Form
    {
        public WinFormsQueries WinFormsQueries { get; set; }
        private readonly PollerThread _pollerThread;

        public ComputerMetricsForm()
        {
            InitializeComponent();
            WinFormsQueries = new WinFormsQueries();
            _pollerThread = new PollerThread();
            _pollerThread.Start();

            StopButton.Hide();
        }

        public void OnThreadUpdated(object sender, EventArgs e)
        {
            WinFormsQueries.AddComputerUsegeData();
            var usegeData = WinFormsQueries.GetComputerUsegeData();
            var time = usegeData.Time?.ToString("mm:ss");
            var cpuUsage = usegeData.CpuUsage;
            var ramUsage = usegeData.RamUsage;

            CpuUsageBox.Clear();
            CpuUsageBox.AppendText(cpuUsage + " %");
            RamUsageBox.Clear();
            RamUsageBox.AppendText(ramUsage + " %");

            UsageChart.Series[0].Points.AddXY(time, cpuUsage);
            UsageChart.Series[1].Points.AddXY(time, ramUsage);
            while (UsageChart.Series[0].Points.Count > 10)
            {
                UsageChart.Series[0].Points.RemoveAt(0);
            }
            while (UsageChart.Series[1].Points.Count > 10)
            {
                UsageChart.Series[1].Points.RemoveAt(0);
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            WinFormsQueries.AddComputerDetail();
            FillTextBoxes(WinFormsQueries.ComputerSummary);
            AddChartSeries();
            StartButton.Hide();
            StopButton.Show();
            ProgramStatusLabel.Text = @"Program status: Running";
            _pollerThread.UpdateFinished += OnThreadUpdated;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearChart();
            _pollerThread.ThreadStopMethod();
            _pollerThread.UpdateFinished -= OnThreadUpdated;
            StopButton.Hide();
            ProgramStatusLabel.Text = @"Program status: Stopped";
            StartButton.Show();
        }

        private void ClearTextBoxes()
        {
            UserNameBox.Clear();
            ComputerNameBox.Clear();
            RamBox.Clear();
            RamUsageBox.Clear();
            CpuUsageBox.Clear();
            CpuBox.Clear();
            IpBox.Clear();
            AverageDiskQueueLengthBox.Clear();
            AvailableDiskSpaceGBBox.Clear();
            VideoCardBox.Clear();
        }

        private void ClearChart()
        {
            UsageChart.Series[0].Points.Clear();
            UsageChart.Series[1].Points.Clear();
            //UsageChart.Series[2].Points.Clear();
            //UsageChart.Series[3].Points.Clear();
        }

        private void ComputerMetricsForm_Load(object sender, EventArgs e)
        {

        }

        private void AddChartSeries()
        {
            UsageChart.Series.Clear();
            UsageChart.ChartAreas[0].AxisY.Maximum = 100;
            UsageChart.ChartAreas[0].AxisY.Interval = 10;
            UsageChart.ChartAreas[0].AxisX.Title = "Time 'mm:ss'";
            UsageChart.ChartAreas[0].AxisY.Title = "%";

            var cpuSeries = new Series("CPU usage")
            {
                AxisLabel = "%",
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 3
            };

            var ramSeries = new Series("RAM Usage")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 3
            };

            var diskSeries = new Series("Disk space usage")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                BorderWidth = 3
            };

            var networkSeries = new Series("Network usage")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Orange,
                BorderWidth = 3
            };



            UsageChart.Series.Add(cpuSeries);
            UsageChart.Series.Add(ramSeries);
            //UsageChart.Series.Add(diskSeries);
            //UsageChart.Series.Add(networkSeries);
        }

        private void FillTextBoxes(ComputerSummary computerMetrics)
        {
            UserNameBox.AppendText(computerMetrics.User);
            ComputerNameBox.AppendText(computerMetrics.Name);
            RamBox.AppendText(computerMetrics.Ram + " MB");
            RamUsageBox.AppendText(computerMetrics.RamUsage + " %");
            CpuUsageBox.AppendText(computerMetrics.CpuUsage + " %");
            CpuBox.AppendText(computerMetrics.Cpu);
            IpBox.AppendText(computerMetrics.Ip.ToString());
            AverageDiskQueueLengthBox.AppendText(computerMetrics.AverageDiskQueueLength.ToString());
            AvailableDiskSpaceGBBox.AppendText(computerMetrics.AvailableDiskSpaceGb + " GB");
            VideoCardBox.AppendText(computerMetrics.VideoCard);
        }
    }
}
