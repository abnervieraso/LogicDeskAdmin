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
    public partial class CESucursal : Bases.MdiChildBase
    {
        CToolTip toolTip;
        public CESucursal()
        {
            InitializeComponent();
            ActiveControl = txbNumero;

            toolTip = new();

            toolTip.SetToolTip(pbSucursal, "Obtener un número aleatorio único");
            toolTip.SetToolTip(pbEncargado, "Buscar usuario");
            toolTip.SetToolTip(pbDelEncargado, "Quitar encargado actual");
           
        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new(snd!.ClientRectangle, Color.White, Color.LightGoldenrodYellow, LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }

    }
}
