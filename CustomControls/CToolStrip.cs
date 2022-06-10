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
    }
}
