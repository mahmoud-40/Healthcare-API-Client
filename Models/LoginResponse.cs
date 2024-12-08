using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    internal class LoginResponse
    {
        public string Token { get; set; }
        public string UserName { get; set; }
    }
}
