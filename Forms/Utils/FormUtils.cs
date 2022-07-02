using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Forms.Utils
{
    public static class FormUtils
    {
        public static Main? MainForm { get; }
        const int X = 25;
        const int Y = 25;

        static FormUtils()
        {
            MainForm = (Main)Application.OpenForms[0];
        }

        public static void OpenNew(Form form)
        {
            form.MdiParent = MainForm;
            if (form.StartPosition == FormStartPosition.Manual && form.WindowState != FormWindowState.Maximized)
            {
                var location = new Point(X, Y);
                if (MainForm?.ActiveMdiChild is Form activeForm)
                {
                    location.X = activeForm.Location.X + location.X;
                    location.Y = activeForm.Location.Y + location.Y;
                }
                form.Location = location;
            }

            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                form.Location = new Point(0, 0);
                var size = MainForm!.MdiArea.Size;
                size.Width -= 5;
                size.Height -= 5;
                form.Size = size;
            }
            
            form.Show();
        }
    }
}
