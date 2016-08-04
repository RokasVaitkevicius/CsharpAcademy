using System.Collections.Generic;

namespace Entity.Models
{
    public class ComputerDetail
    {
        public int ComputerDetailId { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public string VideoCard { get; set; }
        public string Ip { get; set; }

        public ICollection<UsegeData> UsageDataCollection { get; set; }

    }
}
