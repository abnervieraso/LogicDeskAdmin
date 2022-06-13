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
    public partial class RawResponsePreview : Form
    {
        public RawResponsePreview(string? responseContent, uint statusCode)
        {
            InitializeComponent();
            txbContent.Text = responseContent;
            Text += $" {(statusCode)}"; 
        }

        private void OnHeaderPanelPaint(object? sender, PaintEventArgs e)
        {
            var snd = sender as Panel;
            using LinearGradientBrush linearGradientBrush = new (snd!.ClientRectangle, Color.DarkRed, Color.LightGray, 45);
            e.Graphics.FillRectangle(linearGradientBrush, snd.ClientRectangle);
        }
    }
}
