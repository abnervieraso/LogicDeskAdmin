using LogicDeskAdmin.Forms.Utils;

namespace LogicDeskAdmin.Forms
{
    public partial class Main : Form
    {
        public bool AskToClose { get; set; }
        public Main()
        {
            
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            AskToClose = true;

            using var g = CreateGraphics();
            var scale = Math.Max(g.DpiX, g.DpiY) / 96.0;
            Global.ScalingFactor = ((int)Math.Floor(scale * 100) / 50 * 50) / 100.0;

            if (Global.ScalingFactor > 1)
            {
                var result = (int)Global.ScalingFactor;
                
                MainToolStrip.ImageScalingSize = new Size(result, result);
                MainStatusStrip.ImageScalingSize = new Size(result, result);

            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            

            FormUtils.OpenNew(new Login());


        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (AskToClose)
            {
                e.Cancel = true;
                if (MessageBox.Show(this, "¿Desea salir de la aplicación?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AskToClose = false;
                    Close();
                }
            }
        }

        private void usuariosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaUsuarios());
        }

        
    }
}