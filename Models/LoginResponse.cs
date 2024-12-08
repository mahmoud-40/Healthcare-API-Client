using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_API_Client.Models
{
    public class LoginResponse
    {
        public string Token { get; set; }      // JWT Token
        public string UserName { get; set; }  // Optional, depending on API response
    }
}
