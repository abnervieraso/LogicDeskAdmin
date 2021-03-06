namespace LogicDeskAdmin.Forms
{
    partial class CEUsuario
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
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombre = new LogicDeskAdmin.CustomControls.CTextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbDepto = new System.Windows.Forms.ComboBox();
            this.cbMunic = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbIdentidad = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbContacto = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbUsername = new LogicDeskAdmin.CustomControls.CTextBox();
            this.txbPassword = new LogicDeskAdmin.CustomControls.CTextBox();
            this.cbCambiarPass = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txbCodigo = new LogicDeskAdmin.CustomControls.CTextBox();
            this.pbCodigo = new LogicDeskAdmin.CustomControls.DPIPictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ts1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).BeginInit();
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
            this.ts1.Size = new System.Drawing.Size(834, 34);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "cToolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.i_guardar;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(834, 25);
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
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "(usuario nuevo)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 484);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaNac, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbSexo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbIdentidad, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbContacto, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbUsername, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbCambiarPass, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbNombre, 4);
            this.txbNombre.Location = new System.Drawing.Point(187, 3);
            this.txbNombre.MaxLength = 256;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(414, 31);
            this.txbNombre.TabIndex = 3;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.dtpFechaNac, 2);
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(187, 41);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(204, 31);
            this.dtpFechaNac.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbSexo, 2);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(502, 40);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(204, 33);
            this.cbSexo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 102);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(184, 76);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(525, 78);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // cbPais
            // 
            this.cbPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(3, 3);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(256, 33);
            this.cbPais.TabIndex = 7;
            // 
            // cbDepto
            // 
            this.cbDepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepto.FormattingEnabled = true;
            this.cbDepto.Location = new System.Drawing.Point(3, 42);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(256, 33);
            this.cbDepto.TabIndex = 8;
            // 
            // cbMunic
            // 
            this.cbMunic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMunic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunic.FormattingEnabled = true;
            this.cbMunic.Location = new System.Drawing.Point(265, 42);
            this.cbMunic.Name = "cbMunic";
            this.cbMunic.Size = new System.Drawing.Size(257, 33);
            this.cbMunic.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "DUI o identidad:";
            // 
            // txbIdentidad
            // 
            this.txbIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIdentidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbIdentidad, 2);
            this.txbIdentidad.Location = new System.Drawing.Point(187, 157);
            this.txbIdentidad.MaxLength = 256;
            this.txbIdentidad.Name = "txbIdentidad";
            this.txbIdentidad.Size = new System.Drawing.Size(204, 31);
            this.txbIdentidad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Contacto:";
            // 
            // txbContacto
            // 
            this.txbContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbContacto, 2);
            this.txbContacto.Location = new System.Drawing.Point(502, 157);
            this.txbContacto.MaxLength = 256;
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(204, 31);
            this.txbContacto.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre de usuario:";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbUsername, 2);
            this.txbUsername.Location = new System.Drawing.Point(187, 194);
            this.txbUsername.MaxLength = 256;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(204, 31);
            this.txbUsername.TabIndex = 12;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbPassword, 2);
            this.txbPassword.Location = new System.Drawing.Point(187, 231);
            this.txbPassword.MaxLength = 256;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(204, 31);
            this.txbPassword.TabIndex = 13;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // cbCambiarPass
            // 
            this.cbCambiarPass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.cbCambiarPass, 3);
            this.cbCambiarPass.Location = new System.Drawing.Point(187, 268);
            this.cbCambiarPass.Name = "cbCambiarPass";
            this.cbCambiarPass.Size = new System.Drawing.Size(280, 29);
            this.cbCambiarPass.TabIndex = 17;
            this.cbCambiarPass.Text = "Solicitar cambio de contraseña";
            this.cbCambiarPass.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label11, 2);
            this.label11.Location = new System.Drawing.Point(416, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Código de empleado:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txbCodigo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbCodigo, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(604, 228);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(105, 37);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCodigo.Location = new System.Drawing.Point(3, 3);
            this.txbCodigo.MaxLength = 256;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(62, 31);
            this.txbCodigo.TabIndex = 15;
            // 
            // pbCodigo
            // 
            this.pbCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCodigo.Image = global::LogicDeskAdmin.Properties.Resources.i_rayo;
            this.pbCodigo.Location = new System.Drawing.Point(68, 5);
            this.pbCodigo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pbCodigo.Name = "pbCodigo";
            this.pbCodigo.Size = new System.Drawing.Size(27, 27);
            this.pbCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCodigo.TabIndex = 16;
            this.pbCodigo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Permisos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CEUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ts1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "CEUsuario";
            this.Text = "Crear usuario del sistema";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).EndInit();
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
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private CustomControls.CTextBox txbNombre;
        private DateTimePicker dtpFechaNac;
        private Label label5;
        private ComboBox cbSexo;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbPais;
        private ComboBox cbDepto;
        private ComboBox cbMunic;
        private Label label10;
        private Label label7;
        private CustomControls.CTextBox txbIdentidad;
        private Label label8;
        private CustomControls.CTextBox txbContacto;
        private Label label9;
        private CustomControls.CTextBox txbUsername;
        private CustomControls.CTextBox txbPassword;
        private CheckBox cbCambiarPass;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.CTextBox txbCodigo;
        private CustomControls.DPIPictureBox pbCodigo;
    }
}