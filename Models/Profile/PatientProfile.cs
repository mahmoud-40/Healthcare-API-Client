using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models.Profile
{
    internal class PatientProfile
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDay { get; set; }

        public string? Address { get; set; }

        public Gender Gender { get; set; }

        public string? PhoneNumber { get; set; }
    }
}