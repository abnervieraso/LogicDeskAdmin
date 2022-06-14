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
      
        public CToolStrip()
        {
            Stretch = true;
            GripStyle = ToolStripGripStyle.Hidden;
            ImageScalingSize = new Size(16, 16);

            if (Global.ScalingFactor > 1)
            {
                var result = (int)Global.ScalingFactor;
                ImageScalingSize = new Size(result, result);
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
