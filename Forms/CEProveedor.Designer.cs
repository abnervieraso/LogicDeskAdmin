namespace LogicDeskAdmin.Forms
{
    partial class CEProveedor
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombreComercial = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbDepto = new System.Windows.Forms.ComboBox();
            this.cbMunic = new System.Windows.Forms.ComboBox();
            this.txbDireccion = new LogicDeskAdmin.CustomControls.CTextBox();
            this.txbRazonSocial = new LogicDeskAdmin.CustomControls.CTextBox();
            this.cbGranContrib = new System.Windows.Forms.CheckBox();
            this.txbGiro = new LogicDeskAdmin.CustomControls.CTextBox();
            this.txbContacto = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDui = new LogicDeskAdmin.CustomControls.CTextBox();
            this.txnNit = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNrc = new LogicDeskAdmin.CustomControls.CTextBox();
            this.ts1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts1
            // 
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ts1.Size = new System.Drawing.Size(851, 34);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "Barra de herramientas";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.icn_guardar;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(103, 29);
            this.tsbNuevo.Text = "Guardar";
            this.tsbNuevo.ToolTipText = "Guardar y cerrar";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(851, 25);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "(nuevo proveedor)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 629);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbNombreComercial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbDireccion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbRazonSocial, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbGranContrib, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbGiro, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txbContacto, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbDui, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txnNit, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txbNrc, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 585);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(77, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Contacto:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Giro comercial:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "DUI/documento:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre comercial:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razón social:";
            // 
            // txbNombreComercial
            // 
            this.txbNombreComercial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombreComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbNombreComercial, 5);
            this.txbNombreComercial.Location = new System.Drawing.Point(171, 3);
            this.txbNombreComercial.MaxLength = 256;
            this.txbNombreComercial.Name = "txbNombreComercial";
            this.txbNombreComercial.Size = new System.Drawing.Size(549, 31);
            this.txbNombreComercial.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ubicación:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbPais, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbDepto, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbMunic, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(168, 74);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 78);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cbPais
            // 
            this.cbPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(3, 3);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(271, 33);
            this.cbPais.TabIndex = 6;
            // 
            // cbDepto
            // 
            this.cbDepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepto.FormattingEnabled = true;
            this.cbDepto.Location = new System.Drawing.Point(3, 42);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(271, 33);
            this.cbDepto.TabIndex = 7;
            // 
            // cbMunic
            // 
            this.cbMunic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMunic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunic.FormattingEnabled = true;
            this.cbMunic.Location = new System.Drawing.Point(280, 42);
            this.cbMunic.Name = "cbMunic";
            this.cbMunic.Size = new System.Drawing.Size(272, 33);
            this.cbMunic.TabIndex = 8;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbDireccion, 5);
            this.txbDireccion.Location = new System.Drawing.Point(171, 155);
            this.txbDireccion.MaxLength = 256;
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDireccion.Size = new System.Drawing.Size(549, 66);
            this.txbDireccion.TabIndex = 9;
            this.txbDireccion.UseSystemPasswordChar = true;
            // 
            // txbRazonSocial
            // 
            this.txbRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbRazonSocial, 5);
            this.txbRazonSocial.Location = new System.Drawing.Point(171, 40);
            this.txbRazonSocial.MaxLength = 256;
            this.txbRazonSocial.Name = "txbRazonSocial";
            this.txbRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbRazonSocial.Size = new System.Drawing.Size(549, 31);
            this.txbRazonSocial.TabIndex = 4;
            // 
            // cbGranContrib
            // 
            this.cbGranContrib.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.cbGranContrib, 2);
            this.cbGranContrib.Location = new System.Drawing.Point(171, 227);
            this.cbGranContrib.Name = "cbGranContrib";
            this.cbGranContrib.Size = new System.Drawing.Size(210, 29);
            this.cbGranContrib.TabIndex = 10;
            this.cbGranContrib.Text = "Es gran contribuyente";
            this.cbGranContrib.UseVisualStyleBackColor = true;
            // 
            // txbGiro
            // 
            this.txbGiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbGiro, 5);
            this.txbGiro.Location = new System.Drawing.Point(171, 336);
            this.txbGiro.MaxLength = 256;
            this.txbGiro.Multiline = true;
            this.txbGiro.Name = "txbGiro";
            this.txbGiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbGiro.Size = new System.Drawing.Size(549, 66);
            this.txbGiro.TabIndex = 14;
            this.txbGiro.UseSystemPasswordChar = true;
            // 
            // txbContacto
            // 
            this.txbContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbContacto, 5);
            this.txbContacto.Location = new System.Drawing.Point(171, 408);
            this.txbContacto.MaxLength = 256;
            this.txbContacto.Multiline = true;
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbContacto.Size = new System.Drawing.Size(549, 66);
            this.txbContacto.TabIndex = 15;
            this.txbContacto.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "NIT:";
            // 
            // txbDui
            // 
            this.txbDui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDui.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbDui, 2);
            this.txbDui.Location = new System.Drawing.Point(171, 262);
            this.txbDui.MaxLength = 256;
            this.txbDui.Name = "txbDui";
            this.txbDui.Size = new System.Drawing.Size(216, 31);
            this.txbDui.TabIndex = 11;
            // 
            // txnNit
            // 
            this.txnNit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txnNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txnNit, 2);
            this.txnNit.Location = new System.Drawing.Point(504, 262);
            this.txnNit.MaxLength = 256;
            this.txnNit.Name = "txnNit";
            this.txnNit.Size = new System.Drawing.Size(216, 31);
            this.txnNit.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "NRC:";
            // 
            // txbNrc
            // 
            this.txbNrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNrc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbNrc, 2);
            this.txbNrc.Location = new System.Drawing.Point(171, 299);
            this.txbNrc.MaxLength = 256;
            this.txbNrc.Name = "txbNrc";
            this.txbNrc.Size = new System.Drawing.Size(216, 31);
            this.txbNrc.TabIndex = 13;
            // 
            // CEProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 688);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ts1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "CEProveedor";
            this.Text = "Crear proveedor";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.CToolStrip ts1;
        private ToolStripButton tsbNuevo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private CustomControls.CTextBox txbNombreComercial;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbPais;
        private ComboBox cbDepto;
        private ComboBox cbMunic;
        private Label label10;
        private CustomControls.CTextBox txbDireccion;
        private CustomControls.CTextBox txbRazonSocial;
        private CheckBox cbGranContrib;
        private Label label12;
        private Label label15;
        private Label label14;
        private CustomControls.CTextBox txnNit;
        private CustomControls.CTextBox txbGiro;
        private CustomControls.CTextBox txbContacto;
        private Label label5;
        private CustomControls.CTextBox txbDui;
        private Label label7;
        private CustomControls.CTextBox txbNrc;
    }
}