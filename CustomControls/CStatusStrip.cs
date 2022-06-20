using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public partial class CStatusStrip : StatusStrip
    {
        // Escalar los íconos de los botones de los controles Strip
        // Obtiene el DPI actual de la pantalla, luego el factor y se refrescan los items.
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            var scalingFactor = DeviceDpi / 96.0;
            ImageScalingSize = new Size(16, 16);

            if (scalingFactor > 1)
            {
                var sf = (int)(scalingFactor * 16);
                ImageScalingSize = new Size(sf, sf);
            }

            SuspendLayout();
            foreach (ToolStripItem item in Items)
            {
                item.AutoSize = false;
                item.AutoSize = true;
            }
            ResumeLayout();

        }

    }
}
