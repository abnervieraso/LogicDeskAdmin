using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicDeskAdmin.Forms.Bases
{
    public partial class MdiChildBase : Form
    {
        public Binding Busy
        {
            get
            {
                var binding = new Binding("Enabled", Remote.Connection.Instance, "IsBusy");
                binding.Format += (s, e) => e.Value = !(bool?)e.Value;
                return binding;
            }
        }

        public MdiChildBase()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
