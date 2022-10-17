using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAuth.Application.Models
{
    public class ChangePasswordRequest
    {
        public int UserId { get; set; }

        public string PasswordBefore { get; set; } = string.Empty;

        public string PasswordNew { get; set; } = string.Empty;

    }
}
