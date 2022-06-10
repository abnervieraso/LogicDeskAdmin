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
            this.cToolStrip1 = new LogicDeskAdmin.CustomControls.CToolStrip();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // cToolStrip1
            // 
            this.cToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.cToolStrip1.Name = "cToolStrip1";
            this.cToolStrip1.Size = new System.Drawing.Size(986, 25);
            this.cToolStrip1.TabIndex = 1;
            this.cToolStrip1.Text = "cToolStrip1";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 580);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(986, 28);
            this.MainStatusStrip.TabIndex = 2;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 608);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.cToolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "LogicDesk versión 2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CToolStrip cToolStrip1;
        private StatusStrip MainStatusStrip;
        private MenuStrip menuStrip1;
    }
}