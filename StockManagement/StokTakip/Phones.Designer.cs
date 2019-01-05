namespace StokTakip
{
    partial class Phones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phones));
            this.cmBoxBrand = new System.Windows.Forms.ComboBox();
            this.TxtBoxMdlCode = new System.Windows.Forms.TextBox();
            this.dataGridViewPhones = new System.Windows.Forms.DataGridView();
            this.btnDeleteTel = new System.Windows.Forms.Button();
            this.btnInsertTel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBoxBrand
            // 
            resources.ApplyResources(this.cmBoxBrand, "cmBoxBrand");
            this.cmBoxBrand.FormattingEnabled = true;
            this.cmBoxBrand.Name = "cmBoxBrand";
            // 
            // TxtBoxMdlCode
            // 
            resources.ApplyResources(this.TxtBoxMdlCode, "TxtBoxMdlCode");
            this.TxtBoxMdlCode.Name = "TxtBoxMdlCode";
            // 
            // dataGridViewPhones
            // 
            resources.ApplyResources(this.dataGridViewPhones, "dataGridViewPhones");
            this.dataGridViewPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhones.Name = "dataGridViewPhones";
            this.dataGridViewPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDeleteTel
            // 
            resources.ApplyResources(this.btnDeleteTel, "btnDeleteTel");
            this.btnDeleteTel.Name = "btnDeleteTel";
            this.btnDeleteTel.UseVisualStyleBackColor = true;
            this.btnDeleteTel.Click += new System.EventHandler(this.btnDeleteTel_Click);
            // 
            // btnInsertTel
            // 
            resources.ApplyResources(this.btnInsertTel, "btnInsertTel");
            this.btnInsertTel.Name = "btnInsertTel";
            this.btnInsertTel.UseVisualStyleBackColor = true;
            this.btnInsertTel.Click += new System.EventHandler(this.btnInsertTel_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::StokTakip.Properties.Resources._67_512;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // buttonAddStock
            // 
            resources.ApplyResources(this.buttonAddStock, "buttonAddStock");
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // textBoxCount
            // 
            resources.ApplyResources(this.textBoxCount, "textBoxCount");
            this.textBoxCount.Name = "textBoxCount";
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Phones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.btnInsertTel);
            this.Controls.Add(this.btnDeleteTel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewPhones);
            this.Controls.Add(this.TxtBoxMdlCode);
            this.Controls.Add(this.cmBoxBrand);
            this.Name = "Phones";
            this.Load += new System.EventHandler(this.Phones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxBrand;
        private System.Windows.Forms.TextBox TxtBoxMdlCode;
        private System.Windows.Forms.DataGridView dataGridViewPhones;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteTel;
        private System.Windows.Forms.Button btnInsertTel;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonSave;
    }
}