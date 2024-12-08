using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models.Profile
{
    internal class PatientProfile
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeSpan MemberSince { get; set; }
    }
}

/*
    {
     "id": "string",
     "name": "string",
     "age": 0,
     "address": "string",
     "gender": 1,
     "email": "string",
     "phoneNumber": "string",
     "memberSince": "string"
   }
 */