using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models.Records
{
    internal class ViewRecordByPatient
    {
        public int Id { get; set; }
        public string? Treatments { get; set; }
        public TimeSpan LastUpdate { get; set; }
        public TimeSpan Since { get; set; }
        public Provider? Provider { get; set; }
    }
}
