namespace LogicDeskAdmin.Forms
{
    partial class ListaCategoriasProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "creación", System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "(fecha c.)"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "(creador)", System.Drawing.SystemColors.MenuHighlight, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "actualización", System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "(fecha act.)"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "(actualizador)", System.Drawing.SystemColors.MenuHighlight, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point))}, -1);
            this.ts1 = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cToolStrip1 = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripButton();
            this.tsbExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbSelPagina = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.flpBusqueda = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txbBusqueda = new LogicDeskAdmin.CustomControls.CTextBox();
            this.Dgv1 = new LogicDeskAdmin.CustomControls.CDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cToolStrip1.SuspendLayout();
            this.ts2.SuspendLayout();
            this.flpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // ts1
            // 
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.toolStripSeparator1,
            this.tsbEditar,
            this.tsbEliminar,
            this.toolStripSeparator2,
            this.tsbRefrescar});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts1.Size = new System.Drawing.Size(762, 34);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "Barra de opciones";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.i_nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(92, 29);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo elemento";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::LogicDeskAdmin.Properties.Resources.i_editar;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(116, 29);
            this.tsbEditar.Text = "Editar/ver";
            this.tsbEditar.ToolTipText = "Editar o ver elemento seleccionado";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.tsbEliminar.Image = global::LogicDeskAdmin.Properties.Resources.i_equis;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(116, 29);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::LogicDeskAdmin.Properties.Resources.i_equis;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(269, 34);
            this.toolStripMenuItem1.Text = "Eliminar marcado(s)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.Image = global::LogicDeskAdmin.Properties.Resources.i_actualizar;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(111, 29);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.ToolTipText = "Refrescar vista";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView2.Location = new System.Drawing.Point(0, 463);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(762, 67);
            this.listView2.TabIndex = 5;
            this.listView2.TabStop = false;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Atributo";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor1";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor2";
            this.columnHeader3.Width = 175;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 530);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 25);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "elementos: 0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "marcados: 0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "página actual: 1";
            // 
            // cToolStrip1
            // 
            this.cToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5});
            this.cToolStrip1.Location = new System.Drawing.Point(0, 34);
            this.cToolStrip1.Name = "cToolStrip1";
            this.cToolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cToolStrip1.Size = new System.Drawing.Size(762, 34);
            this.cToolStrip1.Stretch = true;
            this.cToolStrip1.TabIndex = 1;
            this.cToolStrip1.Text = "Barra de opciones";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::LogicDeskAdmin.Properties.Resources.i_details;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(236, 29);
            this.toolStripButton5.Text = "Ver productos asociados";
            this.toolStripButton5.ToolTipText = "Ver productos asociados";
            // 
            // ts2
            // 
            this.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFiltrar,
            this.tsbExportar,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsbSelPagina,
            this.toolStripButton3,
            this.toolStripButton4});
            this.ts2.Location = new System.Drawing.Point(0, 68);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts2.Size = new System.Drawing.Size(762, 34);
            this.ts2.Stretch = true;
            this.ts2.TabIndex = 2;
            this.ts2.Text = "Barra de opciones";
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.Image = global::LogicDeskAdmin.Properties.Resources.i_filtar;
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(153, 29);
            this.tsbFiltrar.Text = "Filtrar/ordenar";
            this.tsbFiltrar.ToolTipText = "Filtrar u ordenar elementos";
            // 
            // tsbExportar
            // 
            this.tsbExportar.Image = global::LogicDeskAdmin.Properties.Resources.i_exportar;
            this.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportar.Name = "tsbExportar";
            this.tsbExportar.Size = new System.Drawing.Size(106, 29);
            this.tsbExportar.Text = "Exportar";
            this.tsbExportar.ToolTipText = "Exportar elementos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LogicDeskAdmin.Properties.Resources.i_inicio;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton1.Text = "Ir a primera página";
            this.toolStripButton1.ToolTipText = "Ir a primera página";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LogicDeskAdmin.Properties.Resources.i_atras;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton2.Text = "Ir a página anterior";
            this.toolStripButton2.ToolTipText = "Ir a página anterior";
            // 
            // tsbSelPagina
            // 
            this.tsbSelPagina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelPagina.Image = global::LogicDeskAdmin.Properties.Resources.i_paginar;
            this.tsbSelPagina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelPagina.Name = "tsbSelPagina";
            this.tsbSelPagina.Size = new System.Drawing.Size(34, 29);
            this.tsbSelPagina.Text = "Seleccionar página";
            this.tsbSelPagina.ToolTipText = "Seleccionar página manualmente";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::LogicDeskAdmin.Properties.Resources.i_adelante;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton3.Text = "Ir a siguiente página";
            this.toolStripButton3.ToolTipText = "Ir a siguiente página";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::LogicDeskAdmin.Properties.Resources.i_fin;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton4.Text = "Ir a última página";
            this.toolStripButton4.ToolTipText = "Ir a última página";
            // 
            // flpBusqueda
            // 
            this.flpBusqueda.AutoSize = true;
            this.flpBusqueda.Controls.Add(this.lblBuscar);
            this.flpBusqueda.Controls.Add(this.txbBusqueda);
            this.flpBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBusqueda.Location = new System.Drawing.Point(0, 102);
            this.flpBusqueda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.flpBusqueda.Name = "flpBusqueda";
            this.flpBusqueda.Size = new System.Drawing.Size(762, 47);
            this.flpBusqueda.TabIndex = 3;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 11);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(67, 25);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbBusqueda.Location = new System.Drawing.Point(85, 8);
            this.txbBusqueda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txbBusqueda.MaxLength = 256;
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(293, 31);
            this.txbBusqueda.TabIndex = 3;
            // 
            // Dgv1
            // 
            this.Dgv1.AllowUserToAddRows = false;
            this.Dgv1.AllowUserToDeleteRows = false;
            this.Dgv1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv1.Location = new System.Drawing.Point(0, 149);
            this.Dgv1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Dgv1.MultiSelect = false;
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersVisible = false;
            this.Dgv1.RowHeadersWidth = 62;
            this.Dgv1.RowTemplate.Height = 25;
            this.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv1.Size = new System.Drawing.Size(762, 314);
            this.Dgv1.TabIndex = 4;
            this.Dgv1.VirtualMode = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MaxInputLength = 256;
            this.Column1.MinimumWidth = 35;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.MaxInputLength = 256;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Descripción";
            this.Column3.MaxInputLength = 256;
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListaCategoriasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 555);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.flpBusqueda);
            this.Controls.Add(this.ts2);
            this.Controls.Add(this.cToolStrip1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ts1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ListaCategoriasProducto";
            this.Text = "Maestro de categorías de producto";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.cToolStrip1.ResumeLayout(false);
            this.cToolStrip1.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.flpBusqueda.ResumeLayout(false);
            this.flpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CToolStrip ts1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label2;
        private Label label1;
        private ToolStripButton tsbNuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbEditar;
        private ToolStripDropDownButton tsbEliminar;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbRefrescar;
        private CustomControls.CToolStrip cToolStrip1;
        private ToolStripButton toolStripButton5;
        private CustomControls.CToolStrip ts2;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbExportar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tsbSelPagina;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private FlowLayoutPanel flpBusqueda;
        private Label lblBuscar;
        private CustomControls.CTextBox txbBusqueda;
        private CustomControls.CDataGridView Dgv1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}