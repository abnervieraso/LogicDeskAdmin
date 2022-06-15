using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Forms.Utils
{
    public static class FormUtils
    {
        //Cambiar a init o ver como optimizar
        public static Main? MainForm { get; set; }
        const int X = 25;
        const int Y = 25;

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
