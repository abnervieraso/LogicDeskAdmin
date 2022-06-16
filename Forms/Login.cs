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
using LogicDeskAdmin.Forms.Utils;

namespace LogicDeskAdmin.Forms
{
    public partial class Login : Bases.MdiChildBase
    {
        public Login()
        {
            InitializeComponent();
            ActiveControl = txbUsername;
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            
                FormUtils.MainForm!.AskToClose = false;
                FormUtils.MainForm.Close();
            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new(snd!.ClientRectangle, Color.MidnightBlue, Color.LightBlue, 40);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
