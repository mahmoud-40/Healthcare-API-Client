using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    public  class DoctorOpertionsDTO
    {
        public required string FullName { get; set; }
        public string? Title { get; set; }

        public DateOnly HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public int YearExperience { get; set; } = 0;
    }
}
