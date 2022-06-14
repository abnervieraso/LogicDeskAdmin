using LogicDeskAdmin.Forms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin
{
    public static class Global
    {
        static double _scalingFactor = 1;
        
        public static double ScalingFactor 
        { 
            get => _scalingFactor * 16; 
            set => _scalingFactor = value; 
        }
    }
}
