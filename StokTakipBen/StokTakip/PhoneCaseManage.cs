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
    public partial class PhoneCaseManage : Form
    {
        
        UnitOfWork _uw = new UnitOfWork();
        public PhoneCaseManage()
        {
            InitializeComponent();
        }
       
        public void FillGrid()
        {
            dataGridViewPhoneCaseManage.DataSource = null;
            dataGridViewPhoneCaseManage.DataSource = _uw.PhoneCaseRepo.GetPhoneCases();
        }

        private void PhoneCaseManage_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void StockAdd_Click(object sender, EventArgs e)
        {
            if(dataGridViewPhoneCaseManage.SelectedRows.Count==0)
                new PhoneCaseCreate().Show();
            else
            {
                int SelectedId = (int)dataGridViewPhoneCaseManage.SelectedRows[0].Cells["ID"].Value;
                PhoneCaseCreate f = new PhoneCaseCreate();
                f.SelectedPhoneCase(SelectedId);
                f.Show();
            }
        }

        private void DeleteSelc_Click(object sender, EventArgs e)
        {
           var Result= MessageBox.Show("Silmek istediğinizden eminmisiniz?", "Sil",MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridViewPhoneCaseManage.SelectedRows)
                {
                    int id = (int)item.Cells["ID"].Value;
                    _uw.PhoneCaseRepo.Delete(id);
                }
                FillGrid();
            }
         
        }

     
        private void buttonNewCase_Click(object sender, EventArgs e)
        {
            new PhoneCaseCreate().Show();
            dataGridViewPhoneCaseManage.ClearSelection();
            //buttonNewCase.PerformClick();
        }
    }
}
