using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    internal class Doctor
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string ProviderName { get; set; }
        public DateTime HireDate { get; set; }
        public int YearExperience { get; set; }
    }
}
