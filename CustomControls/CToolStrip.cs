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
            //RenderMode = ToolStripRenderMode.System;
            
            Text = "Barra de herramientas/acciones";
        }

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
