using LogicDeskAdmin.Forms.Utils;

namespace LogicDeskAdmin.Forms
{
    public partial class Main : Form
    {
        public bool AskToClose { get; set; }
        public MdiClient MdiArea { get; }
        public Main()
        { 
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            AskToClose = true;
            MdiArea = Controls.OfType<MdiClient>().First();
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
                if (MessageBox.Show(this, "¿Desea salir de esta aplicación?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaSucursales());
        }

        private void terminalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaTerminales());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaProveedores());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gruposDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaGruposPrecio());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaClientes());

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaProductos());
        }

        private void familiasDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaFamiliasProducto());
        }

        private void categoríasDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new ListaCategoriasProducto());
        }
    }
}