using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public partial class CToolStrip : ToolStrip
    {
        readonly double _scalingFactor;

        public CToolStrip()
        {
            Stretch = true;
            GripStyle = ToolStripGripStyle.Hidden;

            _scalingFactor = DeviceDpi / 96.0 * 16;
            if (_scalingFactor > 1)
            {
                var sf = (int)_scalingFactor;
                ImageScalingSize = new Size(sf, sf);
            }
        }

        

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            /* Para evitar que los botones permanezcan con el efecto "presionado" */
            if (Enabled)
            {
                SuspendLayout();
                foreach (ToolStripItem item in Items)
                {
                    item.Available = false;
                    item.Available = true;
                }
                ResumeLayout();
            }
            
        }
    }
}
