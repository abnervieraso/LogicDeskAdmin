using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Models
{
    public class ResponseWrapper<T>
    {
        public bool IsValidResponse { get; set; }
        public string? RMessage { get; set; }
        public DataWrapper<T>? RData { get; set; }
    }
}
