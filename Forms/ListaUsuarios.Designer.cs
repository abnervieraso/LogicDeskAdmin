namespace LogicDeskAdmin.Forms
{
    partial class ListaUsuarios
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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new LogicDeskAdmin.CustomControls.CToolStrip();
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
            this.ts1.SuspendLayout();
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
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.tsbRefrescar});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts1.Size = new System.Drawing.Size(777, 25);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "cToolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.icon_nuevodoc_28p;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::LogicDeskAdmin.Properties.Resources.icon_editdoc_28p;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(78, 22);
            this.tsbEditar.Text = "Editar/ver";
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
            // 
            // habilitardeshabilitarMarcadosToolStripMenuItem
            // 
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Image = global::LogicDeskAdmin.Properties.Resources.icon_trash_28p;
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Name = "habilitardeshabilitarMarcadosToolStripMenuItem";
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.habilitardeshabilitarMarcadosToolStripMenuItem.Text = "Habilitar/deshabilitar marcado(s)";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = global::LogicDeskAdmin.Properties.Resources.icon_del_28p;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripDropDownButton1.Text = "Eliminar";
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
            this.tsbRefrescar.Image = global::LogicDeskAdmin.Properties.Resources.icon_refresh_28p;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(75, 22);
            this.tsbRefrescar.Text = "Refrescar";
            // 
            // ts2
            // 
            this.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts2.Location = new System.Drawing.Point(0, 25);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts2.Size = new System.Drawing.Size(777, 25);
            this.ts2.Stretch = true;
            this.ts2.TabIndex = 1;
            this.ts2.Text = "cToolStrip2";
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
            this.flpBusqueda.Size = new System.Drawing.Size(777, 33);
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
            this.cTextBox1.Size = new System.Drawing.Size(343, 23);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 343);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 15);
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
            this.label5.Location = new System.Drawing.Point(694, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "0 elemento(s)";
            // 
            // Dgv1
            // 
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv1.Location = new System.Drawing.Point(0, 83);
            this.Dgv1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.RowHeadersWidth = 62;
            this.Dgv1.RowTemplate.Height = 25;
            this.Dgv1.Size = new System.Drawing.Size(777, 260);
            this.Dgv1.TabIndex = 3;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 373);
            this.Controls.Add(this.Dgv1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpBusqueda);
            this.Controls.Add(this.ts2);
            this.Controls.Add(this.ts1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaUsuarios";
            this.Text = "Maestro de usuarios del sistema";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
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
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbRefrescar;
    }
}