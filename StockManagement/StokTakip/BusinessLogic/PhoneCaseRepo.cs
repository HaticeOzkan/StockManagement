using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class PhoneCaseRepo
    {
        public List<PhoneCase> GetPhoneCases()
        {
            List<PhoneCase> PhoneCases = new List<PhoneCase>();
       
            DataTable dt = Program.SqlHelper.GetTable("Select * from PhoneCases");
            foreach (DataRow item in dt.Rows)
            {
                PhoneCase Pc = new PhoneCase();
                Pc.ID =(int) item["ID"];
                Pc.Price = (decimal)item["Price"];
                Pc.ProductName = item["ProductName"].ToString();
                Pc.CaseColor = (CaseColor)item["Color"];
                Pc.StockCount = (int)item["StockCount"];

                PhoneCases.Add(Pc);
            }
            return PhoneCases;
        }
        public void InsertPhoneCase(PhoneCase newPhoneCase)
        {
            #region AlanIsmi
            //bu alan kodları bölmeye yarıyo gizlemeye yaryo
            #endregion
            SqlParameter p1 = new SqlParameter("ProductName",newPhoneCase.ProductName);
            SqlParameter p2 = new SqlParameter("Price", newPhoneCase.Price);
            SqlParameter p3 = new SqlParameter("Color", newPhoneCase.CaseColor);
            SqlParameter p4 = new SqlParameter("StkCount", newPhoneCase.StockCount);
         
            Program.SqlHelper.ExecuteProc("InsertPhoneCase", p1, p2, p3, p4);

        }
        public void AddStockToPhoneCase(int id,int qty)
        {
            //belli bir id deki stok sayısını bu kadar arttırmamız lazım telefon kılıfları tablosuna stok sayısı diye bir alan ekleyebiliriz.
            SqlParameter p1 = new SqlParameter("ID", id);
            SqlParameter p2 = new SqlParameter("StkSay", qty);
            Program.SqlHelper.ExecuteProc("UpdatePhoneCase", p1, p2);

        }
        public void Delete (int id)
        {
            Program.SqlHelper.ExecuteCommand("Delete from Phonecases where ID=" + id);

        }
    }
}
