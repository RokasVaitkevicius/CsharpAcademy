using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using static DataLayer.ComputerMetricsEnum;

namespace DataLayer
{
    public class FullDataManager : DataManager
    {
        public override ComputerSummary GetComputerSummary()
        {
            var computerSummary = new ComputerSummary
            {
                Name = GetMetric(ComputerName),
                User = GetMetric(UserName),
                AvailableDiskSpaceGb = int.Parse(GetMetric(AvailableDiskSpaceGb)),
                Cpu = GetMetric(Cpu),
                Ram = int.Parse(GetMetric(AvailableRam)),
                VideoCard = GetMetric(VideoCard),
                Ip = IPAddress.Parse(GetMetric(Ip)),
                CpuUsage = int.Parse(GetMetric(CpuUsage)),
                RamUsage = int.Parse(GetMetric(RamUsage)),
                AverageDiskQueueLength = int.Parse(GetMetric(AverageDiskQueueLength))
            };
            return computerSummary;
        }

        public override List<string> GetApplicationList() => GetListFromWmi("win32_product");

        public override List<string> GetHardwareList() => GetListFromWmi("win32_pnpentity");

        private static List<string> GetListFromWmi(string query)
        {
            var list = new List<string>();
            var searcher = new ManagementObjectSearcher("select * from " + query);
            foreach (var obj in searcher.Get().Cast<ManagementObject>())
            {
                list.Add(obj["Name"]?.ToString());
            }

            return list;
        }
    }
}
