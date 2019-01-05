namespace StokTakip
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.buttonSale = new System.Windows.Forms.Button();
            this.listBoxSale = new System.Windows.Forms.ListBox();
            this.labelTl = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSale
            // 
            resources.ApplyResources(this.dataGridViewSale, "dataGridViewSale");
            this.dataGridViewSale.AllowUserToAddRows = false;
            this.dataGridViewSale.AllowUserToDeleteRows = false;
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.ReadOnly = true;
            this.dataGridViewSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSale.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // buttonSale
            // 
            resources.ApplyResources(this.buttonSale, "buttonSale");
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSale
            // 
            resources.ApplyResources(this.listBoxSale, "listBoxSale");
            this.listBoxSale.FormattingEnabled = true;
            this.listBoxSale.Name = "listBoxSale";
            // 
            // labelTl
            // 
            resources.ApplyResources(this.labelTl, "labelTl");
            this.labelTl.Name = "labelTl";
            // 
            // textBoxSearch
            // 
            resources.ApplyResources(this.textBoxSearch, "textBoxSearch");
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // Sales
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelTl);
            this.Controls.Add(this.listBoxSale);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.dataGridViewSale);
            this.Name = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.ListBox listBoxSale;
        private System.Windows.Forms.Label labelTl;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}