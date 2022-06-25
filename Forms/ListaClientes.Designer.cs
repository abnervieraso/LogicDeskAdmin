﻿namespace LogicDeskAdmin.Forms
{
    partial class ListaClientes
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
            this.cTextBox1 = new LogicDeskAdmin.CustomControls.CTextBox();
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
            this.ts1.Size = new System.Drawing.Size(628, 25);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "cToolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.icon_add;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo elemento";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::LogicDeskAdmin.Properties.Resources.icon_pencil;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(78, 22);
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
            this.tsbDisable.Size = new System.Drawing.Size(147, 22);
            this.tsbDisable.Text = "Habilitar/deshabilitar";
            this.tsbDisable.ToolTipText = "Habilitar/deshabilitar selección";
            // 
            // habilitardeshabilitarMarcadosToolStripMenuItem
            // 
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Image = global::LogicDeskAdmin.Properties.Resources.icon_trash_28p;
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Name = "habilitardeshabilitarMarcadosToolStripMenuItem";
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Text = "Habilitar/deshabilitar marcado(s)";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.tsbEliminar.Image = global::LogicDeskAdmin.Properties.Resources.icon_del_28p;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(79, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.ToolTipText = "Eliminar selección";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::LogicDeskAdmin.Properties.Resources.icon_del_28p;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Eliminar marcado(s)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.Image = global::LogicDeskAdmin.Properties.Resources.icon_refresh;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(75, 22);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.ToolTipText = "Refrescar vista";
            // 
            // ts2
            // 
            this.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFiltrar,
            this.tsbExportar,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.ts2.Location = new System.Drawing.Point(0, 25);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts2.Size = new System.Drawing.Size(628, 25);
            this.ts2.Stretch = true;
            this.ts2.TabIndex = 1;
            this.ts2.Text = "cToolStrip2";
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.Image = global::LogicDeskAdmin.Properties.Resources.icon_filterorder;
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(103, 22);
            this.tsbFiltrar.Text = "Filtrar/ordenar";
            this.tsbFiltrar.ToolTipText = "Filtrar u ordenar resultado";
            // 
            // tsbExportar
            // 
            this.tsbExportar.Image = global::LogicDeskAdmin.Properties.Resources.icon_statistics;
            this.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportar.Name = "tsbExportar";
            this.tsbExportar.Size = new System.Drawing.Size(71, 22);
            this.tsbExportar.Text = "Exportar";
            this.tsbExportar.ToolTipText = "Exportar resultado";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LogicDeskAdmin.Properties.Resources.icon_firstpage;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Ir a primera página";
            this.toolStripButton1.ToolTipText = "Ir a primera página";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LogicDeskAdmin.Properties.Resources.icon_atras;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Ir a página anterior";
            this.toolStripButton2.ToolTipText = "Ir a página anterior";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(71, 25);
            this.toolStripTextBox1.ToolTipText = "Número de página";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::LogicDeskAdmin.Properties.Resources.icon_adelante;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Ir a siguiente página";
            this.toolStripButton3.ToolTipText = "Ir a siguiente página";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::LogicDeskAdmin.Properties.Resources.icon_lastpage;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Ir a última página";
            this.toolStripButton4.ToolTipText = "Ir a última página";
            // 
            // flpBusqueda
            // 
            this.flpBusqueda.AutoSize = true;
            this.flpBusqueda.Controls.Add(this.lblBuscar);
            this.flpBusqueda.Controls.Add(this.cTextBox1);
            this.flpBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBusqueda.Location = new System.Drawing.Point(0, 50);
            this.flpBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpBusqueda.Name = "flpBusqueda";
            this.flpBusqueda.Size = new System.Drawing.Size(628, 33);
            this.flpBusqueda.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(4, 9);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // cTextBox1
            // 
            this.cTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBox1.Location = new System.Drawing.Point(57, 5);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cTextBox1.MaxLength = 256;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Size = new System.Drawing.Size(206, 23);
            this.cTextBox1.TabIndex = 2;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "0 marcado(s)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creación:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actualización:";
            // 
            // llblCreador
            // 
            this.llblCreador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.llblCreador.AutoSize = true;
            this.llblCreador.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblCreador.Location = new System.Drawing.Point(93, 0);
            this.llblCreador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblCreador.Name = "llblCreador";
            this.llblCreador.Size = new System.Drawing.Size(55, 15);
            this.llblCreador.TabIndex = 2;
            this.llblCreador.TabStop = true;
            this.llblCreador.Text = "(creador)";
            // 
            // llblActualizador
            // 
            this.llblActualizador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.llblActualizador.AutoSize = true;
            this.llblActualizador.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblActualizador.Location = new System.Drawing.Point(93, 15);
            this.llblActualizador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblActualizador.Name = "llblActualizador";
            this.llblActualizador.Size = new System.Drawing.Size(79, 15);
            this.llblActualizador.TabIndex = 3;
            this.llblActualizador.TabStop = true;
            this.llblActualizador.Text = "(actualizador)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "(tiempo de creación)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "(tiempo de modificación)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
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
            this.Dgv1.Location = new System.Drawing.Point(0, 83);
            this.Dgv1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv1.MultiSelect = false;
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersVisible = false;
            this.Dgv1.RowHeadersWidth = 62;
            this.Dgv1.RowTemplate.Height = 25;
            this.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv1.Size = new System.Drawing.Size(628, 217);
            this.Dgv1.TabIndex = 3;
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
            this.Column2.HeaderText = "Nombre completo";
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
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DUI/contacto";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "NRC";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 330);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpBusqueda);
            this.Controls.Add(this.ts2);
            this.Controls.Add(this.ts1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaClientes";
            this.Text = "Maestro de clientes";
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
        private CustomControls.CTextBox cTextBox1;
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