using LogicDeskAdmin.Forms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicDeskAdmin.Forms
{
    public partial class ListaClientes : Bases.MdiChildBase
    {
        public ListaClientes()
        {
            InitializeComponent();
            ActiveControl = txbBusqueda;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new CECliente());
        }
    }
}
