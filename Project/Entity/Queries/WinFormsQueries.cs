using DataLayer;
using Entity.Models;
using System;
using System.Linq;

namespace Entity.Queries
{
    public class WinFormsQueries
    {
        private readonly MetricsContext _context;
        public FullDataManager DataManager { get; set; }
        public ComputerSummary ComputerSummary { get; set; }

        public WinFormsQueries()
        {
            DataManager = new FullDataManager();
            _context = new MetricsContext();
            _context.Database.EnsureCreated();
            ComputerSummary = DataManager.GetComputerSummary();
        }

        public void AddComputerDetail()
        {
            var duplicate = _context.ComputerDetailsSet.FirstOrDefault(a => a.User == ComputerSummary.User);
            if (duplicate == null)
            {
                var computerDetails = new ComputerDetail
                {
                    Name = ComputerSummary.Name,
                    Cpu = ComputerSummary.Cpu,
                    User = ComputerSummary.User,
                    Ram = ComputerSummary.Ram,
                    VideoCard = ComputerSummary.VideoCard,
                    Ip = ComputerSummary.Ip.ToString()
                };

                _context.Add(computerDetails);
                SaveDataToDatabase();
            }
        }

        public void SaveDataToDatabase()
        {
            _context.SaveChanges();
        }

        public void AddComputerUsegeData()
        {
            var cpuUsage = DataManager.GetMetric(ComputerMetricsEnum.CpuUsage);
            var ramUsage = DataManager.GetMetric(ComputerMetricsEnum.RamUsage);
            var avaiableDiskSpaceGb = DataManager.GetMetric(ComputerMetricsEnum.AvailableDiskSpaceGb);
            var averageDiskQueueLength = DataManager.GetMetric(ComputerMetricsEnum.AverageDiskQueueLength);

            var usegeData = new UsageData
            {
                Time = DateTime.Now,
                CpuUsage = int.Parse(cpuUsage),
                RamUsage = int.Parse(ramUsage),
                AvailableDiskSpaceGb = int.Parse(avaiableDiskSpaceGb),
                AverageDiskQueueLength = int.Parse(averageDiskQueueLength),

            };

            _context.Add(usegeData);
            SaveDataToDatabase();
        }

        public UsageData GetComputerUsegeData()
        {
            var usegeData = _context.UsageDatasSet
                .LastOrDefault();

            return usegeData;
        }

    }
}
