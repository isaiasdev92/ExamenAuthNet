using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAuth.Application.Models
{
    public class AuthResponse : ResponseBase
    {
        public string Token { get; set; } = string.Empty;
    }
}
