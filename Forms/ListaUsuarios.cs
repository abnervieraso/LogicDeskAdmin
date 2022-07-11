using LogicDeskAdmin.Forms.Utils;
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
using LogicDeskAdmin.Remote;
using LogicDeskAdmin.Models;

namespace LogicDeskAdmin.Forms
{
    public partial class ListaUsuarios : Bases.ListaBase
    {
        const string recurso = "usuarios";
        readonly List<Usuario> RootList;

        public ListaUsuarios()
        {
            InitializeComponent();
            RootList = new();
 
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new CEUsuario());
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Bs.DataSource = RootList;
            Dgv1.DataSource = Bs;

            ActiveControl = txbBusqueda;

            // DataBindings al elemento seleccionado actual:
            lblCount.DataBindings.Add("Text", this, "Count")
                .Format += (s, e) => e.Value = $"elementos: {e.Value}";
            lblMarcadosCount.DataBindings.Add("Text", this, "Marcados")
                .Format += (s, e) => e.Value = $"marcados: {e.Value}";
            
            ts1.DataBindings.Add(Busy);
            ts2.DataBindings.Add(Busy);
            txbBusqueda.DataBindings.Add("ReadOnly", Connection.Instance, "IsBusy");
            Dgv1.DataBindings.Add(Busy);

            Bs.ListChanged += (s, e) => Marcados = RootList.Count(x => x.Marcado);

            Bs.PositionChanged += (s, e) =>
            {
                //ListView de propiedades
            };

            Dgv1.CellClick += (s, e) => {
                if (e.ColumnIndex == 0)
                {
                    var itm = (Usuario)Dgv1.Rows[e.RowIndex].DataBoundItem;
                    itm.Marcado = !itm.Marcado;
                    Bs.ResetItem(Bs.IndexOf(itm));
                }
            };

            Dgv1.KeyDown += (s, e) => {
                if (e.KeyData == Keys.Space)
                {
                    e.SuppressKeyPress = e.Handled = true;
                    
                    if (Bs.Current is Usuario selected)
                    {
                        selected.Marcado = !selected.Marcado;
                        Bs.ResetCurrentItem();
                    }
                }
            };
        }

        protected override async void RefreshData()
        {
            Bs.Clear();

            Dictionary<string, object> _params = new();
            _params.Add("q", txbBusqueda.Text);
            if (await Request.Get<List<Usuario>>(recurso) is DataWrapper<List<Usuario>> result)
            {
                RootList.AddRange(result.Response!);
                Bs.ResetBindings(false);
            }
        }

        private void OnDgvCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.Value is not null)
                {
                    e.Value = (bool)e.Value ? '\u2714' : null;

                }
            }
        }
    }
}
