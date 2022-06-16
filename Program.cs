using LogicDeskAdmin.Forms.Utils;

namespace LogicDeskAdmin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            using var bmp = new Bitmap(1, 1);
            using var gr = Graphics.FromImage(bmp);
            var scale = Math.Max(gr.DpiX, gr.DpiY) / 96.0;
            Global.ScalingFactor = ((int)Math.Floor(scale * 100) / 50 * 50) / 100.0;

            var mainForm = new Forms.Main();
            FormUtils.MainForm = mainForm;
            Application.Run(mainForm);
        }
    }
}