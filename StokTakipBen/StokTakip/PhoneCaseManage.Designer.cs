namespace StokTakip
{
    partial class PhoneCaseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneCaseManage));
            this.StockAdd = new System.Windows.Forms.Button();
            this.dataGridViewPhoneCaseManage = new System.Windows.Forms.DataGridView();
            this.DeleteSelc = new System.Windows.Forms.Button();
            this.buttonNewCase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneCaseManage)).BeginInit();
            this.SuspendLayout();
            // 
            // StockAdd
            // 
            resources.ApplyResources(this.StockAdd, "StockAdd");
            this.StockAdd.Name = "StockAdd";
            this.StockAdd.UseVisualStyleBackColor = true;
            this.StockAdd.Click += new System.EventHandler(this.StockAdd_Click);
            // 
            // dataGridViewPhoneCaseManage
            // 
            resources.ApplyResources(this.dataGridViewPhoneCaseManage, "dataGridViewPhoneCaseManage");
            this.dataGridViewPhoneCaseManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneCaseManage.Name = "dataGridViewPhoneCaseManage";
            this.dataGridViewPhoneCaseManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // DeleteSelc
            // 
            resources.ApplyResources(this.DeleteSelc, "DeleteSelc");
            this.DeleteSelc.Name = "DeleteSelc";
            this.DeleteSelc.UseVisualStyleBackColor = true;
            this.DeleteSelc.Click += new System.EventHandler(this.DeleteSelc_Click);
            // 
            // buttonNewCase
            // 
            resources.ApplyResources(this.buttonNewCase, "buttonNewCase");
            this.buttonNewCase.Name = "buttonNewCase";
            this.buttonNewCase.UseVisualStyleBackColor = true;
            this.buttonNewCase.Click += new System.EventHandler(this.buttonNewCase_Click);
            // 
            // PhoneCaseManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNewCase);
            this.Controls.Add(this.DeleteSelc);
            this.Controls.Add(this.dataGridViewPhoneCaseManage);
            this.Controls.Add(this.StockAdd);
            this.Name = "PhoneCaseManage";
            this.Load += new System.EventHandler(this.PhoneCaseManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneCaseManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StockAdd;
        private System.Windows.Forms.DataGridView dataGridViewPhoneCaseManage;
        private System.Windows.Forms.Button DeleteSelc;
        private System.Windows.Forms.Button buttonNewCase;
    }
}