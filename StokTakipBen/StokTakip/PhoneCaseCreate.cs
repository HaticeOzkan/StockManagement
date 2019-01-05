using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class PhoneCaseCreate : Form
    {// sınıfın yapısını dinamik alıp inceleyen bir yapı var refleksın ile halledilir 
       // Bu enum nasıl yazılır inceletecez
        public PhoneCaseCreate()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void PhoneCaseCreate_Load(object sender, EventArgs e)
        {
            FillPhoneCasesCombo();
            FillColors();
            RefreshCurrentStock();
        }
        public void SelectedPhoneCase(int Id)
        {
            tabControl1.SelectTab(1);
            comboBoxCase.SelectedValue = Id;
                
        }

        private void FillPhoneCasesCombo()
        {
            comboBoxCase.DataSource = null;
            comboBoxCase.DisplayMember = "ProductName";
            comboBoxCase.ValueMember = "ID";
            comboBoxCase.DataSource = _uw.PhoneCaseRepo.GetPhoneCases();
        }

        private void FillColors()
        {
            // tipini bilmek istiyorum yapıyla alakalı bilgi getirir 
            // t ye attım butun değişkenlerin bilgisini
            Type T = typeof(CaseColor);
            List<string> options;
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                //Normal Değerler(ingilizce) 
                options = T.GetEnumNames().ToList();//to list eleyince string dizisini listye ceviriyor
            }
            else
            {

                var Attrs = T.GetFields().SelectMany(x => x.CustomAttributes);
                var AttrNames = Attrs.SelectMany(x => x.ConstructorArguments);
                options = AttrNames.Select(x => (string)x.Value).ToList();
            }

            cmBoxColor.DataSource = options;
        }

       

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            numericUpDownQuantity.Value = 0;
            NumUpDwnPrice.Value = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            PhoneCase p = new PhoneCase();
            p.ProductName = txtName.Text;
            p.CaseColor = (CaseColor)cmBoxColor.SelectedIndex;
            p.Price = NumUpDwnPrice.Value;
            p.StockCount = (int)numericUpDownQuantity.Value;
            _uw.PhoneCaseRepo.InsertPhoneCase(p);
            RefreshMainGrid();

        }

        private void RefreshMainGrid()
        {
            PhoneCaseManage f = (PhoneCaseManage)Application.OpenForms["PhoneCaseManage"];
            if(f!=null)
            f.FillGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int Id = (int)comboBoxCase.SelectedValue;
            int Qty = (int)numericUpDownCase.Value;
            _uw.PhoneCaseRepo.AddStockToPhoneCase(Id,Qty);

            RefreshMainGrid();
            FillPhoneCasesCombo();
       
            }

        private void RefreshCurrentStock()
        {
            if (comboBoxCase.SelectedItem == null)
                return;
            string Template = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en" ? "Stock will be updated to 0 when saved" : "Kaydettiğinizde adet 0 olarak güncellenecektir.";
            var ChosenCase = (PhoneCase)comboBoxCase.SelectedItem;
            var CurrentStock = ChosenCase.StockCount;
            int Latest = CurrentStock + (int)numericUpDownQuantity.Value;
            label.Text = Template.Replace("0", Latest.ToString());
            //RefreshMainGrid();
           // FillPhoneCasesCombo();

        }
        private void numericUpDownCase_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshCurrentStock();
        }

        private void numericUpDownCase_ValueChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }

        private void comboBoxCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }
    }
}
