using DataLayer;
using Entity.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerMetricsWinForms
{
    public partial class ComputerMetricsForm : Form
    {
        public FullDataManager DataManager { get; set; }
        private readonly MetricsContext _context;

        public ComputerMetricsForm()
        {
            InitializeComponent();
            DataManager = new FullDataManager();
            _context = new MetricsContext();
            _context.Database.EnsureCreated();

            StopButton.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            var time = DateTime.Now.ToString("mm:ss");
            var cpuUsage = DataManager.GetMetric(ComputerMetricsEnum.CpuUsage);
            var ramUsage = DataManager.GetMetric(ComputerMetricsEnum.RamUsage);
            var diskUsage = DataManager.GetAvailableDiskSpaceInPercent();
            //var networkUsage = DataManager.GetBandwithUsage();

            CpuUsageBox.Clear();
            CpuUsageBox.AppendText(cpuUsage + " %");
            RamUsageBox.Clear();
            RamUsageBox.AppendText(ramUsage + " %");

            UsageChart.Series[0].Points.AddXY(time, cpuUsage);
            UsageChart.Series[1].Points.AddXY(time, ramUsage);
            UsageChart.Series[2].Points.AddXY(time, diskUsage);
            //UsageChart.Series[3].Points.AddXY(time, networkUsage);

            var usegeData = new UsegeData
            {
                Time = DateTime.Now,
                CpuUsage = int.Parse(cpuUsage),
                RamUsage = int.Parse(ramUsage),
                AvailableDiskSpaceGb = int.Parse(diskUsage)
            };


            while (UsageChart.Series[0].Points.Count > 10)
            {
                UsageChart.Series[0].Points.RemoveAt(0);
            }
            while (UsageChart.Series[1].Points.Count > 10)
            {
                UsageChart.Series[1].Points.RemoveAt(0);
            }
            while (UsageChart.Series[2].Points.Count > 10)
            {
                UsageChart.Series[2].Points.RemoveAt(0);
            }
            //while (UsageChart.Series[3].Points.Count > 10)
            //{
            //    UsageChart.Series[3].Points.RemoveAt(0);
            //}

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var computerMetrics = DataManager.GetComputerSummary();

            if (_context.ComputerDetailsSet.Any(o => o.User != computerMetrics.User))
            {
                var computerDetails = new ComputerDetail
                {
                    Name = computerMetrics.Name,
                    Cpu = computerMetrics.Cpu,
                    User = computerMetrics.User,
                    Ram = computerMetrics.Ram,
                    VideoCard = computerMetrics.VideoCard,
                    Ip = computerMetrics.Ip.ToString()
                };

                _context.Add(computerDetails);
                _context.SaveChanges();
            }

            FillTextBoxes(computerMetrics);
            AddChartSeries();

            timer.Start();
            StartButton.Hide();
            StopButton.Show();
            ProgramStatusLabel.Text = @"Program status: Running";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearChart();
            timer.Stop();
            StartButton.Show();
            StopButton.Hide();
            ProgramStatusLabel.Text = @"Program status: Stopped";
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
            UsageChart.Series[2].Points.Clear();
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
            UsageChart.Series.Add(diskSeries);
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
