using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public class CDataGridView : DataGridView
    {
 
        public CDataGridView()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            VirtualMode = true;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            BackgroundColor = Color.WhiteSmoke;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            GridColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.Fixed3D;
            //EnableHeadersVisualStyles = false;
        }

        // No permitir ordenar columnas ya que el DataSource no es de tipo DataTable
        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (e.Column is DataGridViewTextBoxColumn col)
                col.MaxInputLength = 256;

        }

        // Se soluciona el problema: cuando se elimina una fila y la selección se "pierde"
        protected override void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e)
        {
            base.OnRowsRemoved(e);
            if (CurrentCell != null)
            {
                CurrentCell.Selected = true;

            }
        }

        // Cuando DGV se enfoca, este no "scrolea" hasta la fila seleccionada actualmente.
        // Este void soluciona eso.
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            BeginInvoke(() => {
                if (CurrentCell != null)
                {
                    CurrentCell.Selected = true;

                }
            });


        }

    }
}
