using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public class CToolStrip : ToolStrip
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GripStyle = ToolStripGripStyle.Hidden;
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
