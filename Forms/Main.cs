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
    }
}