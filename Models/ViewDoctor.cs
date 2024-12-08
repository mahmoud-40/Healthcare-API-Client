using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    public  class ViewDoctor
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? ProviderName { get; set; }
        public DateOnly HireDate { get; set; }
        public int YearExperience { get; set; }
    }
}
