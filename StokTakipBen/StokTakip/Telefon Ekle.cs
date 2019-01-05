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
    public partial class Telefon_Ekle : Form
    {
        public Telefon_Ekle()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void Telefon_Ekle_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandComboBox(cmBoxBrand, Resources.Choose);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Phone NewPhone = new Phone();
            NewPhone.Brand = (Brand)cmBoxBrand.SelectedItem;
            NewPhone.IMEI1 = txtBxIMEI1.Text;
            NewPhone.IMEI2 = txtIMEI2.Text;
            NewPhone.Price = NumUpDwnPrice.Value;
            NewPhone.ProductName = txtName.Text;
            NewPhone.ModelCode = txtMdlCode.Text;
            NewPhone.StockCount = (int)numericUpDownCountP.Value;
            _uw.PhoneRepo.InsertPhone(NewPhone);
            RefreshMainPhoneGrid();
        }
        private void RefreshMainPhoneGrid()
        {
            Form OpenForm = Application.OpenForms["Phones"];
            Phones pcForm = (Phones)OpenForm;
            pcForm.FillPhonesGrid();
           
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBoxPhoneCreate.Controls)
            {
                if (item is TextBox || item is ComboBox || item is NumericUpDown)
                {
                    item.Text = "";
                }
             

            }
        }

       
    }
}
