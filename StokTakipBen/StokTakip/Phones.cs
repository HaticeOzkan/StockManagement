using StokTakip.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Phones : Form
    {
        public Phones()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void Phones_Load(object sender, EventArgs e)
        {          
            FillBrandsCombobox();
            FillPhonesGrid();
            textBoxCount.Clear();
            textBoxCount.Enabled = false;
            buttonSave.Enabled = false;
            buttonAddStock.Enabled = true;
           
        }

        private void ClearOutOfStock()
        {

            for (int i = 0; i < dataGridViewPhones.RowCount; i++)
            {
                int Count = (int)dataGridViewPhones.Rows[i].Cells["StockCount"].Value;
                if (Count==0)
                {
                   int ID=(int)dataGridViewPhones.Rows[i].Cells["No"].Value;
                    _uw.PhoneRepo.DeletePhones(ID);
                }
                   
            }
            FillPhonesGrid();

        }

        public void FillPhonesGrid()
        {
            dataGridViewPhones.DataSource = null;
            dataGridViewPhones.DataSource = _uw.PhoneRepo.GetPhonesForDisplay();
            
        }

        private void FillBrandsCombobox()
        {
            UIHelper.FillBrandComboBox(cmBoxBrand,Resources.AllBrands);
      
        }

        private void btnInsertTel_Click(object sender, EventArgs e)
        {
            new Telefon_Ekle().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPhones.DataSource = null;
            int chosenBrandId = (int)cmBoxBrand.SelectedValue;
            if (TxtBoxMdlCode.Text == "Seçiniz" || TxtBoxMdlCode.Text == "Choose")
                TxtBoxMdlCode.Text = "";
            dataGridViewPhones.DataSource = _uw.PhoneRepo.SearchPhone(chosenBrandId,TxtBoxMdlCode.Text);
        }

        private void btnDeleteTel_Click(object sender, EventArgs e)
        {
           var Result= MessageBox.Show("Silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo);
            if(Result==DialogResult.Yes)
            {
                int ID = 0;
                foreach (DataGridViewRow item in dataGridViewPhones.SelectedRows)
                {
                    ID = (int)item.Cells["No"].Value;
                }
                _uw.PhoneRepo.DeletePhones(ID);
                FillPhonesGrid();
            }
           
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            buttonAddStock.Enabled = false;
            buttonSave.Enabled = true;
            textBoxCount.Enabled = true;
         
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateStock();           
            Phones_Load(sender, e);

        }

        private void UpdateStock()
        {
            int ID = 0;

            foreach (DataGridViewRow item in dataGridViewPhones.SelectedRows)
            {
                ID = (int)item.Cells["No"].Value;
            }
            _uw.PhoneRepo.AddStockCountPhone(ID, Convert.ToInt32(textBoxCount.Text));
        }
    }
}
