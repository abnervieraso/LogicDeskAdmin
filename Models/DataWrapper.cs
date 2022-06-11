using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Models
{
    public class DataWrapper<T>
    {
        public T? Data { get; set; }
        public uint ActionCode { get; set; }
    }
}
