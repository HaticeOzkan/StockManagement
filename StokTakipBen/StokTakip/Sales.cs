using StokTakip.ViewModels;
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
    public partial class Sales : Form
    {
        //en az eforla satış ekranı oluştur aynı anda bir suru sey satabilmek lazım 2 tane kılıf 3 tane telefon istiyor fiyat totalini göster
        public Sales()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();

  
        private void FillGrid()
        {
            dataGridViewSale.DataSource = null;
            dataGridViewSale.DataSource = SalesManager.GetProducts();
            listBoxSale.DisplayMember = "ProductName";

            int[] widths = { 40, 160, 120, 150, 150 };
            for (int i = 0; i < widths.Length; i++)
                dataGridViewSale.Columns[i].Width = widths[i];
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //çift tıklanan satırı al
            var cells = dataGridViewSale.SelectedRows[0].Cells;

            //satırdaki ürünün cinsini bul
            Product p;
            if (cells["IMEI1"].Value == "")
                p = new PhoneCase();
            else
                p = new Phone();

            //ürünün isim, fiyat, ID bilgilerini tut
            p.ID = (int)cells["ID"].Value;
            p.Price = (decimal)cells["Price"].Value;
            p.ProductName = cells["ProductName"].Value.ToString();

            //tutulan bilgileri listboxa aktar
            listBoxSale.Items.Add(p);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (Product item in listBoxSale.Items)
                total += item.Price;

            labelTl.Text = total.ToString("C");
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSale.DataSource = SalesManager.GetProducts(textBoxSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> list =  listBoxSale.Items.Cast<Product>().ToList();
            SalesManager.SellProducts(list);
        
            string message = list.Count + " ürün stoktan düşüldü:";

            decimal total = 0;
            foreach (var item in list)
            {
                message += Environment.NewLine;
                message += item.ProductName + " (" + item.Price + ")";
                total += item.Price;
            }
            message += Environment.NewLine;
            message += Environment.NewLine;
            message += "Toplam: " + total;
            MessageBox.Show(message);
            FillGrid();
            listBoxSale.Items.Clear();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}

