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
    public partial class CEUsuario : Bases.MdiChildBase
    {
        CToolTip toolTip;
        public CEUsuario()
        {
            InitializeComponent();
            ActiveControl = txbNombre;

            toolTip = new();
            toolTip.SetToolTip(pbCodigo, "Obtener un código único aleatorio");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new(snd!.ClientRectangle, Color.White, Color.LightGreen, LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }

    }
}
