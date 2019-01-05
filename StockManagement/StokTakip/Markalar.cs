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
    public partial class Markalar : Form
    {
        UnitOfWork _uw = new UnitOfWork();
        public Markalar()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Brand b = new Brand() { BrandName = txtBoxBrand.Text };
            _uw.BrandRepo.InsertBrand(b);  
              listBoxBrand.DataSource = null;
            txtBoxBrand.Clear();
            Markalar_Load(sender,e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _uw.BrandRepo.DeleteBrand((int)listBoxBrand.SelectedValue);
            Markalar_Load(sender, e);

        }    
        private void Markalar_Load(object sender, EventArgs e)
        {
           
            GetData();              
        }
        private void GetData(Brand BrandName=null)
        {
            listBoxBrand.DisplayMember = "BrandName";
            listBoxBrand.ValueMember = "ID";
            listBoxBrand.DataSource = _uw.BrandRepo.GetBrands();
            //suanda datagridview görüntülenen alanlar hoş değil görsellik için yeni klasor ekledik
        }

    }
}
