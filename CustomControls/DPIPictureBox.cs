using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public class DPIPictureBox : PictureBox
    {
        public DPIPictureBox()
        {
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new Size(16, 16);

            var scalingFactor = DeviceDpi / 96.0;
            if (scalingFactor > 1)
            {
                var sf = (int)(scalingFactor * 16);
                Size = new Size(sf, sf);
            }
        }
    }
}
