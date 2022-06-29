namespace LogicDeskAdmin.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainToolStrip = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.combosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.familiasDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gruposDePrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new LogicDeskAdmin.CustomControls.CStatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 33);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainToolStrip.Size = new System.Drawing.Size(1214, 34);
            this.MainToolStrip.Stretch = true;
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "Menú de herramientas principal";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::LogicDeskAdmin.Properties.Resources.icon_location_28p;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(255, 29);
            this.toolStripButton1.Text = "(esperando identificación...)";
            this.toolStripButton1.ToolTipText = "Sucursal de preferencia";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.entornoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1214, 33);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menú estándar principal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // entornoToolStripMenuItem
            // 
            this.entornoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosDelSistemaToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.terminalesToolStripMenuItem,
            this.cientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.entornoToolStripMenuItem.Name = "entornoToolStripMenuItem";
            this.entornoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.entornoToolStripMenuItem.Text = "Entorno";
            // 
            // usuariosDelSistemaToolStripMenuItem
            // 
            this.usuariosDelSistemaToolStripMenuItem.Name = "usuariosDelSistemaToolStripMenuItem";
            this.usuariosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.usuariosDelSistemaToolStripMenuItem.Text = "Usuarios del sistema";
            this.usuariosDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuariosDelSistemaToolStripMenuItem_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // terminalesToolStripMenuItem
            // 
            this.terminalesToolStripMenuItem.Name = "terminalesToolStripMenuItem";
            this.terminalesToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.terminalesToolStripMenuItem.Text = "Terminales";
            this.terminalesToolStripMenuItem.Click += new System.EventHandler(this.terminalesToolStripMenuItem_Click);
            // 
            // cientesToolStripMenuItem
            // 
            this.cientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.categoríasDeClienteToolStripMenuItem});
            this.cientesToolStripMenuItem.Name = "cientesToolStripMenuItem";
            this.cientesToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.cientesToolStripMenuItem.Text = "Clientes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // categoríasDeClienteToolStripMenuItem
            // 
            this.categoríasDeClienteToolStripMenuItem.Name = "categoríasDeClienteToolStripMenuItem";
            this.categoríasDeClienteToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.categoríasDeClienteToolStripMenuItem.Text = "Categorías de cliente";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.combosToolStripMenuItem,
            this.toolStripSeparator1,
            this.familiasDeProductoToolStripMenuItem,
            this.categoríasDeProductoToolStripMenuItem,
            this.toolStripSeparator3,
            this.gruposDePrecioToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(302, 34);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // combosToolStripMenuItem
            // 
            this.combosToolStripMenuItem.Name = "combosToolStripMenuItem";
            this.combosToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.combosToolStripMenuItem.Text = "Combos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(299, 6);
            // 
            // familiasDeProductoToolStripMenuItem
            // 
            this.familiasDeProductoToolStripMenuItem.Name = "familiasDeProductoToolStripMenuItem";
            this.familiasDeProductoToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.familiasDeProductoToolStripMenuItem.Text = "Familias de producto";
            // 
            // categoríasDeProductoToolStripMenuItem
            // 
            this.categoríasDeProductoToolStripMenuItem.Name = "categoríasDeProductoToolStripMenuItem";
            this.categoríasDeProductoToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.categoríasDeProductoToolStripMenuItem.Text = "Categorías de producto";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(299, 6);
            // 
            // gruposDePrecioToolStripMenuItem
            // 
            this.gruposDePrecioToolStripMenuItem.Name = "gruposDePrecioToolStripMenuItem";
            this.gruposDePrecioToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.gruposDePrecioToolStripMenuItem.Text = "Grupos de precio";
            this.gruposDePrecioToolStripMenuItem.Click += new System.EventHandler(this.gruposDePrecioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 671);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.MainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.MainStatusStrip.Size = new System.Drawing.Size(1214, 32);
            this.MainStatusStrip.TabIndex = 6;
            this.MainStatusStrip.Text = "Barra de estado principal";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Image = global::LogicDeskAdmin.Properties.Resources.icon_computermsg_28p;
            this.toolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(448, 25);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "(esperando...)";
            this.toolStripStatusLabel3.ToolTipText = "Último estado de respuesta del servidor";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = global::LogicDeskAdmin.Properties.Resources.icon_user_28p;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(251, 25);
            this.toolStripStatusLabel2.Text = "(esperando identificación...)";
            this.toolStripStatusLabel2.ToolTipText = "Nombre de usuario actual";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::LogicDeskAdmin.Properties.Resources.icon_cloudduplex_28p;
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(448, 25);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Listo";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.ToolTipText = "Estado actual";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 703);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Main";
            this.Text = "LogicDesk Runner versión 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CToolStrip MainToolStrip;
        private MenuStrip MenuStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem entornoToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem usuariosDelSistemaToolStripMenuItem;
        private CustomControls.CStatusStrip MainStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem cientesToolStripMenuItem;
        private ToolStripMenuItem sucursalesToolStripMenuItem;
        private ToolStripMenuItem terminalesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem categoríasDeClienteToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem combosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem familiasDeProductoToolStripMenuItem;
        private ToolStripMenuItem categoríasDeProductoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem gruposDePrecioToolStripMenuItem;
    }
}