namespace LogicDeskAdmin.Forms
{
    partial class CETerminal
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
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pbSucursal = new LogicDeskAdmin.CustomControls.DPIPictureBox();
            this.pbDelSucursal = new LogicDeskAdmin.CustomControls.DPIPictureBox();
            this.txbSucursal = new LogicDeskAdmin.CustomControls.CTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbGrupoPrecios = new LogicDeskAdmin.CustomControls.DPIPictureBox();
            this.pbDelGrupoPrecios = new LogicDeskAdmin.CustomControls.DPIPictureBox();
            this.txbGrupoPrecios = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMarca = new LogicDeskAdmin.CustomControls.CTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txbNumero = new LogicDeskAdmin.CustomControls.CTextBox();
            this.pbNumeroCaja = new LogicDeskAdmin.CustomControls.DPIPictureBox();
            this.txbDescripcion = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbModelo = new LogicDeskAdmin.CustomControls.CTextBox();
            this.txbNumeroSerie = new LogicDeskAdmin.CustomControls.CTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txbAutorizacion = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbRangoInicial = new LogicDeskAdmin.CustomControls.CTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbRangoFinal = new LogicDeskAdmin.CustomControls.CTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFactSinExistencias = new System.Windows.Forms.CheckBox();
            this.ts1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelSucursal)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrupoPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelGrupoPrecios)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumeroCaja)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "(terminal nueva)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 446);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 408);
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
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbMarca, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txbModelo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txbNumeroSerie, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Número de serie:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 5);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.pbSucursal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbDelSucursal, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txbSucursal, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(159, 133);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(560, 37);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // pbSucursal
            // 
            this.pbSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSucursal.Image = global::LogicDeskAdmin.Properties.Resources.icon_browsefolder;
            this.pbSucursal.Location = new System.Drawing.Point(496, 5);
            this.pbSucursal.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pbSucursal.Name = "pbSucursal";
            this.pbSucursal.Size = new System.Drawing.Size(27, 27);
            this.pbSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSucursal.TabIndex = 18;
            this.pbSucursal.TabStop = false;
            // 
            // pbDelSucursal
            // 
            this.pbDelSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbDelSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelSucursal.Image = global::LogicDeskAdmin.Properties.Resources.icon_crossdel;
            this.pbDelSucursal.Location = new System.Drawing.Point(528, 5);
            this.pbDelSucursal.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pbDelSucursal.Name = "pbDelSucursal";
            this.pbDelSucursal.Size = new System.Drawing.Size(27, 27);
            this.pbDelSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelSucursal.TabIndex = 17;
            this.pbDelSucursal.TabStop = false;
            // 
            // txbSucursal
            // 
            this.txbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbSucursal.Location = new System.Drawing.Point(3, 3);
            this.txbSucursal.MaxLength = 256;
            this.txbSucursal.Name = "txbSucursal";
            this.txbSucursal.ReadOnly = true;
            this.txbSucursal.Size = new System.Drawing.Size(490, 31);
            this.txbSucursal.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pbGrupoPrecios, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbDelGrupoPrecios, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbGrupoPrecios, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 170);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(448, 37);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // pbGrupoPrecios
            // 
            this.pbGrupoPrecios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbGrupoPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGrupoPrecios.Image = global::LogicDeskAdmin.Properties.Resources.icon_browsefolder;
            this.pbGrupoPrecios.Location = new System.Drawing.Point(384, 5);
            this.pbGrupoPrecios.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pbGrupoPrecios.Name = "pbGrupoPrecios";
            this.pbGrupoPrecios.Size = new System.Drawing.Size(27, 27);
            this.pbGrupoPrecios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrupoPrecios.TabIndex = 18;
            this.pbGrupoPrecios.TabStop = false;
            // 
            // pbDelGrupoPrecios
            // 
            this.pbDelGrupoPrecios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbDelGrupoPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelGrupoPrecios.Image = global::LogicDeskAdmin.Properties.Resources.icon_crossdel;
            this.pbDelGrupoPrecios.Location = new System.Drawing.Point(416, 5);
            this.pbDelGrupoPrecios.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pbDelGrupoPrecios.Name = "pbDelGrupoPrecios";
            this.pbDelGrupoPrecios.Size = new System.Drawing.Size(27, 27);
            this.pbDelGrupoPrecios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelGrupoPrecios.TabIndex = 17;
            this.pbDelGrupoPrecios.TabStop = false;
            // 
            // txbGrupoPrecios
            // 
            this.txbGrupoPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbGrupoPrecios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbGrupoPrecios.Location = new System.Drawing.Point(3, 3);
            this.txbGrupoPrecios.MaxLength = 256;
            this.txbGrupoPrecios.Name = "txbGrupoPrecios";
            this.txbGrupoPrecios.ReadOnly = true;
            this.txbGrupoPrecios.Size = new System.Drawing.Size(378, 31);
            this.txbGrupoPrecios.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de caja:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sucursal/almacen:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Grupo de precios:";
            // 
            // txbMarca
            // 
            this.txbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbMarca, 2);
            this.txbMarca.Location = new System.Drawing.Point(162, 210);
            this.txbMarca.MaxLength = 256;
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(218, 31);
            this.txbMarca.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.txbNumero, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbNumeroCaja, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(159, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(112, 37);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txbNumero
            // 
            this.txbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNumero.Location = new System.Drawing.Point(3, 3);
            this.txbNumero.MaxLength = 256;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(69, 31);
            this.txbNumero.TabIndex = 4;
            // 
            // pbNumeroCaja
            // 
            this.pbNumeroCaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbNumeroCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNumeroCaja.Image = global::LogicDeskAdmin.Properties.Resources.icon_browsefolder;
            this.pbNumeroCaja.Location = new System.Drawing.Point(75, 5);
            this.pbNumeroCaja.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pbNumeroCaja.Name = "pbNumeroCaja";
            this.pbNumeroCaja.Size = new System.Drawing.Size(27, 27);
            this.pbNumeroCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNumeroCaja.TabIndex = 16;
            this.pbNumeroCaja.TabStop = false;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbDescripcion, 4);
            this.txbDescripcion.Location = new System.Drawing.Point(162, 40);
            this.txbDescripcion.MaxLength = 256;
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDescripcion.Size = new System.Drawing.Size(442, 90);
            this.txbDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Modelo:";
            // 
            // txbModelo
            // 
            this.txbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbModelo, 2);
            this.txbModelo.Location = new System.Drawing.Point(162, 247);
            this.txbModelo.MaxLength = 256;
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(218, 31);
            this.txbModelo.TabIndex = 11;
            // 
            // txbNumeroSerie
            // 
            this.txbNumeroSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txbNumeroSerie, 2);
            this.txbNumeroSerie.Location = new System.Drawing.Point(162, 284);
            this.txbNumeroSerie.MaxLength = 256;
            this.txbNumeroSerie.Name = "txbNumeroSerie";
            this.txbNumeroSerie.Size = new System.Drawing.Size(218, 31);
            this.txbNumeroSerie.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autorización";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Controls.Add(this.txbAutorizacion, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txbRangoInicial, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.txbRangoFinal, 5, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(837, 402);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txbAutorizacion
            // 
            this.txbAutorizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel5.SetColumnSpan(this.txbAutorizacion, 4);
            this.txbAutorizacion.Location = new System.Drawing.Point(192, 3);
            this.txbAutorizacion.MaxLength = 256;
            this.txbAutorizacion.Multiline = true;
            this.txbAutorizacion.Name = "txbAutorizacion";
            this.txbAutorizacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbAutorizacion.Size = new System.Drawing.Size(422, 90);
            this.txbAutorizacion.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Texto de autorización:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Rango inicial:";
            // 
            // txbRangoInicial
            // 
            this.txbRangoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRangoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel5.SetColumnSpan(this.txbRangoInicial, 2);
            this.txbRangoInicial.Location = new System.Drawing.Point(192, 99);
            this.txbRangoInicial.MaxLength = 256;
            this.txbRangoInicial.Name = "txbRangoInicial";
            this.txbRangoInicial.Size = new System.Drawing.Size(208, 31);
            this.txbRangoInicial.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label12, 2);
            this.label12.Location = new System.Drawing.Point(508, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Rango final:";
            // 
            // txbRangoFinal
            // 
            this.txbRangoFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRangoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel5.SetColumnSpan(this.txbRangoFinal, 2);
            this.txbRangoFinal.Location = new System.Drawing.Point(620, 99);
            this.txbRangoFinal.MaxLength = 256;
            this.txbRangoFinal.Name = "txbRangoFinal";
            this.txbRangoFinal.Size = new System.Drawing.Size(214, 31);
            this.txbRangoFinal.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(843, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuración";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 7;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Controls.Add(this.cbFactSinExistencias, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(837, 402);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // cbFactSinExistencias
            // 
            this.cbFactSinExistencias.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.cbFactSinExistencias, 3);
            this.cbFactSinExistencias.Location = new System.Drawing.Point(3, 3);
            this.cbFactSinExistencias.Name = "cbFactSinExistencias";
            this.cbFactSinExistencias.Size = new System.Drawing.Size(360, 29);
            this.cbFactSinExistencias.TabIndex = 3;
            this.cbFactSinExistencias.Text = "Permitir facturar sin existencias al público";
            this.cbFactSinExistencias.UseVisualStyleBackColor = true;
            // 
            // CETerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 505);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ts1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "CETerminal";
            this.Text = "Crear terminal/caja";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelSucursal)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrupoPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelGrupoPrecios)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumeroCaja)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label6;
        private Label label10;
        private Label label7;
        private Label label9;
        private CustomControls.CTextBox txbMarca;
        private TableLayoutPanel tableLayoutPanel4;
        private CustomControls.CTextBox txbNumero;
        private CustomControls.DPIPictureBox pbNumeroCaja;
        private CustomControls.CTextBox txbDescripcion;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.DPIPictureBox pbGrupoPrecios;
        private CustomControls.DPIPictureBox pbDelGrupoPrecios;
        private CustomControls.CTextBox txbGrupoPrecios;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.DPIPictureBox pbSucursal;
        private CustomControls.DPIPictureBox pbDelSucursal;
        private CustomControls.CTextBox txbSucursal;
        private Label label3;
        private CustomControls.CTextBox txbModelo;
        private CustomControls.CTextBox txbNumeroSerie;
        private TableLayoutPanel tableLayoutPanel5;
        private CustomControls.CTextBox txbAutorizacion;
        private Label label8;
        private Label label11;
        private CustomControls.CTextBox txbRangoInicial;
        private Label label12;
        private CustomControls.CTextBox txbRangoFinal;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox cbFactSinExistencias;
    }
}