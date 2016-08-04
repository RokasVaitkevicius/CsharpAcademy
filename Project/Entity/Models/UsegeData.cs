using System;

namespace Entity.Models
{
    public class UsegeData
    {
        public int UsegeDataId { get; set; }
        public DateTime? Time { get; set; }
        public int CpuUsage { get; set; }
        public int RamUsage { get; set; }
        public int AvailableDiskSpaceGb { get; set; }
        public int AverageDiskQueueLength { get; set; }
    }
}
