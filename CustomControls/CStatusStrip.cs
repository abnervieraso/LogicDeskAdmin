using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public partial class CStatusStrip : StatusStrip
    {
        public CStatusStrip()
        {
            
            ImageScalingSize = new Size(16, 16);

            if (Global.ScalingFactor > 1)
            {
                var result = (int)Global.ScalingFactor;
                ImageScalingSize = new Size(result, result);
            }
        }

    }
}
