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
            //Obtener factor de escala de DPI y borrar systemDiagnostic wirte lines de todos lados.
            using var bmp = new Bitmap(16, 16);
            using var gr = Graphics.FromImage(bmp);
            var scale = Math.Max(gr.DpiX, gr.DpiY) / 96.0;
            Global.ScalingFactor = ((int)Math.Floor(scale * 100) / 50 * 50) / 100.0;
            System.Diagnostics.Debug.WriteLine(Global.ScalingFactor);
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = new Forms.Main();
            FormUtils.MainForm = mainForm;
            Application.Run(mainForm);
        }
    }
}