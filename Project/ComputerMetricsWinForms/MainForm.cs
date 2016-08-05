using DataLayer;
using Entity.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerMetricsWinForms
{
    public partial class ComputerMetricsForm : Form
    {
        private readonly WinFormsQueries _winFormsQueries;
        private readonly PollerThread _pollerThread;

        public ComputerMetricsForm()
        {
            InitializeComponent();
            _winFormsQueries = new WinFormsQueries();
            _pollerThread = new PollerThread();
            _pollerThread.Start();
            StopButton.Hide();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _winFormsQueries.AddComputerDetail();

            FillTextBoxes(_winFormsQueries.ComputerSummary);
            AddChartSeries();
            StartButton.Hide();
            StopButton.Show();
            ProgramStatusLabel.Text = @"Program status: Running";

            _pollerThread.UpdateFinished += OnThreadUpdated;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _pollerThread.UpdateFinished -= OnThreadUpdated;
            ClearTextBoxes();
            ClearChart();
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
        }

        private void ComputerMetricsForm_Load(object sender, EventArgs e)
        {

        }

        public void OnThreadUpdated(object sender, EventArgs e)
        {
            _winFormsQueries.AddComputerUsageData();
            var usegeData = _winFormsQueries.GetComputerUsageData();
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

            UsageChart.Series.Add(cpuSeries);
            UsageChart.Series.Add(ramSeries);
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
