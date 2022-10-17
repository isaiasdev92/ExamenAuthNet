using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAuth.Application.Models
{
    public abstract class ResponseBase
    {
        public bool Status { get; set; }

        public string Message { get; set; } = string.Empty;
    }
}
