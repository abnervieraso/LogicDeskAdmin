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
            Margin = new Padding(0, 0, 15, 0);
            
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            var scalingFactor = DeviceDpi / 96.0;
            Size = new Size(18, 18);

            if (scalingFactor > 1)
            {
                var sf = (int)(scalingFactor * 18);
                Size = new Size(sf, sf);
            }

            

        }

        
    }
}
