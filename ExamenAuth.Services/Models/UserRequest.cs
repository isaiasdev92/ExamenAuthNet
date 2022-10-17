using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAuth.Application.Models
{
    public class UserRequest
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
