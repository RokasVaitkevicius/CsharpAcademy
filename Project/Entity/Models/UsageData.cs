using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class UsageData
    {
        [Key]
        public int UsageDataId { get; set; }
        public DateTime? Time { get; set; }
        public int CpuUsage { get; set; }
        public int RamUsage { get; set; }
        public int AvailableDiskSpaceGb { get; set; }
        public int AverageDiskQueueLength { get; set; }
        public int ComputerDetailId { get; set; }

        public ComputerDetail ComputerDetail { get; set; }
    }
}
