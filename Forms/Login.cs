using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicDeskAdmin.Forms.Utils;

namespace LogicDeskAdmin.Forms
{
    public partial class Login : Bases.MdiChildBase
    {
        public Login()
        {
            InitializeComponent();
            ActiveControl = txbUsername;
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            if (FormUtils.MainForm is Main mainForm)
            {
                mainForm.AskToClose = false;
                mainForm.Close();
            }

        }
    }
}
