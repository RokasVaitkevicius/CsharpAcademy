using DataLayer;
using Entity.Models;
using System;
using System.Linq;

namespace Entity.Repository
{
    public class WinFormsQueries
    {
        private readonly MetricsContext _context;
        private readonly FullDataManager _dataManager;
        public ComputerSummary ComputerSummary { get; }
        private int CurrentComputerId { get; set; }

        public WinFormsQueries()
        {
            _dataManager = new FullDataManager();
            _context = new MetricsContext();
            _context.Database.EnsureCreated();
            ComputerSummary = _dataManager.GetComputerSummary();
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
                _context.SaveChanges();
            }

            var currenComputer = _context.ComputerDetailsSet.FirstOrDefault(c => c.User == ComputerSummary.User);
            CurrentComputerId = currenComputer.ComputerDetailId;
        }

        public void AddComputerUsageData()
        {
            var cpuUsage = _dataManager.GetMetric(ComputerMetricsEnum.CpuUsage);
            var ramUsage = _dataManager.GetMetric(ComputerMetricsEnum.RamUsage);
            var avaiableDiskSpaceGb = _dataManager.GetMetric(ComputerMetricsEnum.AvailableDiskSpaceGb);
            var averageDiskQueueLength = _dataManager.GetMetric(ComputerMetricsEnum.AverageDiskQueueLength);

            var usageData = new UsageData
            {
                Time = DateTime.Now,
                CpuUsage = int.Parse(cpuUsage),
                RamUsage = int.Parse(ramUsage),
                AvailableDiskSpaceGb = int.Parse(avaiableDiskSpaceGb),
                AverageDiskQueueLength = int.Parse(averageDiskQueueLength),
                ComputerDetailId = CurrentComputerId
            };

            _context.Add(usageData);
            _context.SaveChanges();
        }

        public UsageData GetComputerUsageData()
        {
            var usageData = _context.UsageDatasSet
                .LastOrDefault();

            return usageData;
        }

    }
}
