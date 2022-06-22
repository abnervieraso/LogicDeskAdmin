namespace LogicDeskAdmin.Forms
{
    partial class CECliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombre = new LogicDeskAdmin.CustomControls.CTextBox();
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
            this.cTextBox1 = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbCambiarPass = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cTextBox2 = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cTextBox3 = new LogicDeskAdmin.CustomControls.CTextBox();
            this.cTextBox4 = new LogicDeskAdmin.CustomControls.CTextBox();
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
            this.ts1.Size = new System.Drawing.Size(851, 34);
            this.ts1.Stretch = true;
            this.ts1.TabIndex = 0;
            this.ts1.Text = "cToolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::LogicDeskAdmin.Properties.Resources.icon_saveclose;
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
            this.flowLayoutPanel1.Controls.Add(this.label4);
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
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(105, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "(cliente nuevo)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 731);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 693);
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
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbIdentidad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbContacto, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbUsername, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbPassword, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbCambiarPass, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox2, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox3, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cTextBox4, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 687);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 536);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Contacto:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Dirección:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Categoría:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Giro:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción:";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbNombre, 4);
            this.txbNombre.Location = new System.Drawing.Point(172, 3);
            this.txbNombre.MaxLength = 256;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(438, 31);
            this.txbNombre.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ubicación:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbPais, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbDepto, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbMunic, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(169, 141);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 80);
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
            this.cbPais.Size = new System.Drawing.Size(271, 33);
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
            this.cbDepto.Size = new System.Drawing.Size(271, 33);
            this.cbDepto.TabIndex = 8;
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
            this.cbMunic.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 227);
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
            this.txbIdentidad.Location = new System.Drawing.Point(172, 224);
            this.txbIdentidad.MaxLength = 256;
            this.txbIdentidad.Name = "txbIdentidad";
            this.txbIdentidad.Size = new System.Drawing.Size(216, 31);
            this.txbIdentidad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "NIT:";
            // 
            // txbContacto
            // 
            this.txbContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbContacto, 2);
            this.txbContacto.Location = new System.Drawing.Point(505, 224);
            this.txbContacto.MaxLength = 256;
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(216, 31);
            this.txbContacto.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "NRC:";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbUsername, 2);
            this.txbUsername.Location = new System.Drawing.Point(172, 261);
            this.txbUsername.MaxLength = 256;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(216, 31);
            this.txbUsername.TabIndex = 12;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbPassword, 5);
            this.txbPassword.Location = new System.Drawing.Point(172, 298);
            this.txbPassword.MaxLength = 256;
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPassword.Size = new System.Drawing.Size(549, 66);
            this.txbPassword.TabIndex = 13;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // cTextBox1
            // 
            this.cTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.cTextBox1, 5);
            this.cTextBox1.Location = new System.Drawing.Point(172, 40);
            this.cTextBox1.MaxLength = 256;
            this.cTextBox1.Multiline = true;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cTextBox1.Size = new System.Drawing.Size(549, 59);
            this.cTextBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sexo:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 33);
            this.comboBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label11, 2);
            this.label11.Location = new System.Drawing.Point(432, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker1, 2);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 31);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBox1, 2);
            this.checkBox1.Location = new System.Drawing.Point(172, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 29);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Exentar de IVA";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbCambiarPass
            // 
            this.cbCambiarPass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.cbCambiarPass, 3);
            this.cbCambiarPass.Location = new System.Drawing.Point(394, 370);
            this.cbCambiarPass.Name = "cbCambiarPass";
            this.cbCambiarPass.Size = new System.Drawing.Size(210, 29);
            this.cbCambiarPass.TabIndex = 17;
            this.cbCambiarPass.Text = "Es gran contribuyente";
            this.cbCambiarPass.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox2, 2);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 405);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 33);
            this.comboBox2.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBox2, 2);
            this.checkBox2.Location = new System.Drawing.Point(448, 407);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(162, 29);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Margen propio:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cTextBox2
            // 
            this.cTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cTextBox2.Location = new System.Drawing.Point(616, 406);
            this.cTextBox2.MaxLength = 256;
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Size = new System.Drawing.Size(105, 31);
            this.cTextBox2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(727, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "%";
            // 
            // cTextBox3
            // 
            this.cTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.cTextBox3, 5);
            this.cTextBox3.Location = new System.Drawing.Point(172, 444);
            this.cTextBox3.MaxLength = 256;
            this.cTextBox3.Multiline = true;
            this.cTextBox3.Name = "cTextBox3";
            this.cTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cTextBox3.Size = new System.Drawing.Size(549, 66);
            this.cTextBox3.TabIndex = 30;
            this.cTextBox3.UseSystemPasswordChar = true;
            // 
            // cTextBox4
            // 
            this.cTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.cTextBox4, 5);
            this.cTextBox4.Location = new System.Drawing.Point(172, 516);
            this.cTextBox4.MaxLength = 256;
            this.cTextBox4.Multiline = true;
            this.cTextBox4.Name = "cTextBox4";
            this.cTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cTextBox4.Size = new System.Drawing.Size(549, 66);
            this.cTextBox4.TabIndex = 32;
            this.cTextBox4.UseSystemPasswordChar = true;
            // 
            // CECliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 790);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ts1);
            this.Name = "CECliente";
            this.Text = "Crear cliente";
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
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private CustomControls.CTextBox txbNombre;
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
        private CustomControls.CTextBox cTextBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Label label12;
        private ComboBox comboBox2;
        private Label label15;
        private Label label14;
        private CheckBox checkBox2;
        private CustomControls.CTextBox cTextBox2;
        private Label label13;
        private CustomControls.CTextBox cTextBox3;
        private CustomControls.CTextBox cTextBox4;
    }
}