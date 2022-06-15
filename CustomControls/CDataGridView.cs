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
        List<int> colX = new List<int>();

        

        public CDataGridView()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            BackgroundColor = Color.WhiteSmoke;
            RowHeadersVisible = false;
            

        }

        

    }
}
