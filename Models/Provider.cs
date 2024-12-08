using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    internal class Provider
    {
        public string Id { get; set; }  
        public string Name { get; set; }
        public string Bio { get; set; }
        public int Shift { get; set; }
        public float Rate { get; set; }  
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public TimeSpan MemberSince { get; set; }
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }

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
