using LogicDeskAdmin.Forms.Utils;
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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            using var g = CreateGraphics();
            var scale = Math.Max(g.DpiX, g.DpiY) / 96.0;
            Global.ScalingFactor = ((int)Math.Floor(scale * 100) / 50 * 50) / 100.0;
        }

        private void tlp1_Paint(object sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new(snd!.ClientRectangle, Color.MidnightBlue, Color.Blue, 45);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }

        

        private void Splash_Shown(object sender, EventArgs e)
        {

            var mainForm = new Main();
            FormUtils.MainForm = mainForm;
            mainForm.FormClosed += (s, e) => Close();
            Hide();
            mainForm.Show();
        }
    }
}
