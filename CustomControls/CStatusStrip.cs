using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public partial class CStatusStrip : StatusStrip
    {
        readonly double _scalingFactor;

        public CStatusStrip()
        {
            _scalingFactor = DeviceDpi / 96.0 * 16;
            if (_scalingFactor > 1)
            {
                var sf = (int)_scalingFactor;
                ImageScalingSize = new Size(sf, sf);
            }
        }

    }
}
