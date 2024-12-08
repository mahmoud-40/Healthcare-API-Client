using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    internal class Appointment
    {
        public int DoctorId { get; set; }
        public DateOnly Date { get; set; }
        public int Time { get; set; }
        public Reason Reason { get; set; } = Reason.Checkup;
    }

    internal enum Reason
    {
        Checkup = 1,
        FollowUp = 2,
        Emergency = 3
    }
}
