using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    internal class UserRegister
    {
        public string? Name { get; set; } 
        public required string UserName { get; set; } 
        public required string Email { get; set; }
        public required string Password { get; set; } 
        public required string ConfirmPassword { get; set; } 
        public AppUserType UserType { get; set; }  
        public Gender Gender { get; set; } 
        public Shift Shift { get; set; }
        public string? Address { get; set; } 
        public DateOnly BirthDay { get; set; }

    }

    enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum Shift
    {
        Morning = 1,
        Evening = 2,
        Night = 3
    }

    enum AppUserType
    {
        Patient = 1,
        Provider = 2,
        Admin = 3
    }
}
