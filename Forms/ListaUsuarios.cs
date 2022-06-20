﻿using LogicDeskAdmin.Forms.Utils;
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
    public partial class ListaUsuarios : Bases.MdiChildBase
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNew(new CEUsuario());
        }
    }
}
