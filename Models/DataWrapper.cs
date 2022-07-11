using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Models
{
    public class DataWrapper<T>
    {
        public T? Response { get; set; }
        public uint RActionCode { get; set; }
    }
}
