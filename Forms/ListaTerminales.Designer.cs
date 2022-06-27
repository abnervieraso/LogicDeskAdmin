namespace LogicDeskAdmin.Forms
{
    partial class ListaTerminales
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
            this.ts1 = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbDisable = new System.Windows.Forms.ToolStripDropDownButton();
            this.habilitardeshabilitarMarcadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEliminar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripButton();
            this.tsbExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.flpBusqueda = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txbBusqueda = new LogicDeskAdmin.CustomControls.CTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llblCreador = new LogicDeskAdmin.CustomControls.CLinkLabel();
            this.llblActualizador = new LogicDeskAdmin.CustomControls.CLinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv1 = new LogicDeskAdmin.CustomControls.CDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts1.SuspendLayout();
            this.ts2.SuspendLayout();
            this.flpBusqueda.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tsbDisable,
            this.tsbEliminar,
            this.toolStripSeparator2,
            this.tsbRefrescar});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts1.Size = new System.Drawing.Size(1113, 34);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "Barra de opciones";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.icon_add;
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
            this.tsbEditar.Image = global::LogicDeskAdmin.Properties.Resources.icon_pencil;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(116, 29);
            this.tsbEditar.Text = "Editar/ver";
            this.tsbEditar.ToolTipText = "Editar o ver elemento seleccionado";
            // 
            // tsbDisable
            // 
            this.tsbDisable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitardeshabilitarMarcadosToolStripMenuItem});
            this.tsbDisable.Image = global::LogicDeskAdmin.Properties.Resources.icon_trash_28p;
            this.tsbDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisable.Name = "tsbDisable";
            this.tsbDisable.Size = new System.Drawing.Size(218, 29);
            this.tsbDisable.Text = "Habilitar/deshabilitar";
            this.tsbDisable.ToolTipText = "Habilitar/deshabilitar selección";
            // 
            // habilitardeshabilitarMarcadosToolStripMenuItem
            // 
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Image = global::LogicDeskAdmin.Properties.Resources.icon_trash_28p;
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Name = "habilitardeshabilitarMarcadosToolStripMenuItem";
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Size = new System.Drawing.Size(371, 34);
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Text = "Habilitar/deshabilitar marcado(s)";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.tsbEliminar.Image = global::LogicDeskAdmin.Properties.Resources.icon_del_28p;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(116, 29);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::LogicDeskAdmin.Properties.Resources.icon_del_28p;
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
            this.tsbRefrescar.Image = global::LogicDeskAdmin.Properties.Resources.icon_refresh;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(111, 29);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.ToolTipText = "Refrescar vista";
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
            this.toolStripTextBox1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.ts2.Location = new System.Drawing.Point(0, 34);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts2.Size = new System.Drawing.Size(1113, 34);
            this.ts2.Stretch = true;
            this.ts2.TabIndex = 1;
            this.ts2.Text = "Barra de opciones";
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.Image = global::LogicDeskAdmin.Properties.Resources.icon_filterorder;
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(153, 29);
            this.tsbFiltrar.Text = "Filtrar/ordenar";
            this.tsbFiltrar.ToolTipText = "Filtrar u ordenar resultado";
            // 
            // tsbExportar
            // 
            this.tsbExportar.Image = global::LogicDeskAdmin.Properties.Resources.icon_statistics;
            this.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportar.Name = "tsbExportar";
            this.tsbExportar.Size = new System.Drawing.Size(106, 29);
            this.tsbExportar.Text = "Exportar";
            this.tsbExportar.ToolTipText = "Exportar resultado";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LogicDeskAdmin.Properties.Resources.icon_firstpage;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton1.Text = "Ir a primera página";
            this.toolStripButton1.ToolTipText = "Ir a primera página";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LogicDeskAdmin.Properties.Resources.icon_atras;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton2.Text = "Ir a página anterior";
            this.toolStripButton2.ToolTipText = "Ir a página anterior";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(101, 34);
            this.toolStripTextBox1.ToolTipText = "Número de página";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::LogicDeskAdmin.Properties.Resources.icon_adelante;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton3.Text = "Ir a siguiente página";
            this.toolStripButton3.ToolTipText = "Ir a siguiente página";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::LogicDeskAdmin.Properties.Resources.icon_lastpage;
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
            this.flpBusqueda.Location = new System.Drawing.Point(0, 68);
            this.flpBusqueda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.flpBusqueda.Name = "flpBusqueda";
            this.flpBusqueda.Size = new System.Drawing.Size(1113, 47);
            this.flpBusqueda.TabIndex = 2;
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
            this.txbBusqueda.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.llblCreador, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.llblActualizador, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 505);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 50);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(992, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "0 marcado(s)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creación:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actualización:";
            // 
            // llblCreador
            // 
            this.llblCreador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.llblCreador.AutoSize = true;
            this.llblCreador.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblCreador.Location = new System.Drawing.Point(137, 0);
            this.llblCreador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llblCreador.Name = "llblCreador";
            this.llblCreador.Size = new System.Drawing.Size(82, 25);
            this.llblCreador.TabIndex = 7;
            this.llblCreador.TabStop = true;
            this.llblCreador.Text = "(creador)";
            // 
            // llblActualizador
            // 
            this.llblActualizador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.llblActualizador.AutoSize = true;
            this.llblActualizador.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblActualizador.Location = new System.Drawing.Point(137, 25);
            this.llblActualizador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llblActualizador.Name = "llblActualizador";
            this.llblActualizador.Size = new System.Drawing.Size(117, 25);
            this.llblActualizador.TabIndex = 8;
            this.llblActualizador.TabStop = true;
            this.llblActualizador.Text = "(actualizador)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "(tiempo de creación)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "(tiempo de modificación)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(988, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "0 elemento(s)";
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv1.Location = new System.Drawing.Point(0, 115);
            this.Dgv1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Dgv1.MultiSelect = false;
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersVisible = false;
            this.Dgv1.RowHeadersWidth = 62;
            this.Dgv1.RowTemplate.Height = 25;
            this.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv1.Size = new System.Drawing.Size(1113, 390);
            this.Dgv1.TabIndex = 5;
            this.Dgv1.VirtualMode = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 35;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Número";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sucursal";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Grupo de precios";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListaTerminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 555);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpBusqueda);
            this.Controls.Add(this.ts2);
            this.Controls.Add(this.ts1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ListaTerminales";
            this.Text = "Maestro de terminales/cajas";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.flpBusqueda.ResumeLayout(false);
            this.flpBusqueda.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CToolStrip ts1;
        private CustomControls.CToolStrip ts2;
        private FlowLayoutPanel flpBusqueda;
        private Label lblBuscar;
        private CustomControls.CTextBox txbBusqueda;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CDataGridView Dgv1;
        private Label label1;
        private Label label2;
        private CustomControls.CLinkLabel llblCreador;
        private CustomControls.CLinkLabel llblActualizador;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private ToolStripButton tsbNuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbEditar;
        private ToolStripDropDownButton tsbDisable;
        private ToolStripMenuItem habilitardeshabilitarMarcadosToolStripMenuItem;
        private ToolStripDropDownButton tsbEliminar;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbRefrescar;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbExportar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}