using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    public class ViewProvider
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? bio { get; set; }
        public Shift Shift { get; set; }
        public float Rate { get; set; }

        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public List<ViewDoctor> Doctors { get; set; } = new List<ViewDoctor>();
        public TimeSpan MemberSince { get; set; }


    }
   

   
}
