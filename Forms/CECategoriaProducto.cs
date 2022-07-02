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
    public partial class CECategoriaProducto : Bases.MdiChildBase
    {
        public CECategoriaProducto()
        {
            InitializeComponent();
            ActiveControl = txbNombre;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new(snd!.ClientRectangle, Color.White, Color.LightGray, LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }

    }
}
