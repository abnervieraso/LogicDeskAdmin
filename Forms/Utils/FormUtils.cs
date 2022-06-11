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
            MainForm = Application.OpenForms[0] as Main;
        }

        public static void OpenNew(Form form)
        {
            form.MdiParent = MainForm;
            if (form.StartPosition == FormStartPosition.Manual)
            {
                var location = new Point(X, Y);
                if (MainForm?.ActiveMdiChild is Form activeForm)
                {
                    location.X = activeForm.Location.X + location.X;
                    location.Y = activeForm.Location.Y + location.Y;
                }
                form.Location = location;
            }
            
            form.Show();
        }
    }
}
