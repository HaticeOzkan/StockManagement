namespace StokTakip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kılıflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingilizceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.dilToolStripMenuItem,
            this.satışToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            resources.ApplyResources(this.tanımlarToolStripMenuItem, "tanımlarToolStripMenuItem");
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markalarToolStripMenuItem,
            this.telefonlarToolStripMenuItem,
            this.kılıflarToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            // 
            // markalarToolStripMenuItem
            // 
            resources.ApplyResources(this.markalarToolStripMenuItem, "markalarToolStripMenuItem");
            this.markalarToolStripMenuItem.Name = "markalarToolStripMenuItem";
            this.markalarToolStripMenuItem.Click += new System.EventHandler(this.markalarToolStripMenuItem_Click);
            // 
            // telefonlarToolStripMenuItem
            // 
            resources.ApplyResources(this.telefonlarToolStripMenuItem, "telefonlarToolStripMenuItem");
            this.telefonlarToolStripMenuItem.Name = "telefonlarToolStripMenuItem";
            this.telefonlarToolStripMenuItem.Click += new System.EventHandler(this.telefonlarToolStripMenuItem_Click);
            // 
            // kılıflarToolStripMenuItem
            // 
            resources.ApplyResources(this.kılıflarToolStripMenuItem, "kılıflarToolStripMenuItem");
            this.kılıflarToolStripMenuItem.Name = "kılıflarToolStripMenuItem";
            this.kılıflarToolStripMenuItem.Click += new System.EventHandler(this.kılıflarToolStripMenuItem_Click);
            // 
            // dilToolStripMenuItem
            // 
            resources.ApplyResources(this.dilToolStripMenuItem, "dilToolStripMenuItem");
            this.dilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türkçeToolStripMenuItem,
            this.ingilizceToolStripMenuItem});
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            // 
            // türkçeToolStripMenuItem
            // 
            resources.ApplyResources(this.türkçeToolStripMenuItem, "türkçeToolStripMenuItem");
            this.türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            this.türkçeToolStripMenuItem.Click += new System.EventHandler(this.türkçeToolStripMenuItem_Click);
            // 
            // ingilizceToolStripMenuItem
            // 
            resources.ApplyResources(this.ingilizceToolStripMenuItem, "ingilizceToolStripMenuItem");
            this.ingilizceToolStripMenuItem.Name = "ingilizceToolStripMenuItem";
            this.ingilizceToolStripMenuItem.Click += new System.EventHandler(this.ingilizceToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            resources.ApplyResources(this.satışToolStripMenuItem, "satışToolStripMenuItem");
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingilizceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kılıflarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
    }
}

