using LogicDeskAdmin.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicDeskAdmin.Forms
{
    public partial class CETerminal : Bases.MdiChildBase
    {
        CToolTip toolTip;
        public CETerminal()
        {
            InitializeComponent();
            ActiveControl = txbNumero;

            toolTip = new();
            toolTip.SetToolTip(pbNumeroCaja, "Obtener un número único aleatorio");
            toolTip.SetToolTip(pbSucursal, "Seleccionar sucursal");
            toolTip.SetToolTip(pbDelSucursal, "Quitar sucursal actual");
            toolTip.SetToolTip(pbGrupoPrecios, "Seleccionar grupo de precios");
            toolTip.SetToolTip(pbDelGrupoPrecios, "Quitar grupo de precios actual");

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new(snd!.ClientRectangle, Color.White, Color.LightPink, LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }

        
    }
}
