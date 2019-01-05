using StokTakip.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneRepo
    {
        public List<Phone> GetPhones()
        {
            List<Phone> List = new List<Phone>();
            //fill the list
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow item in dt.Rows)
            {
                Phone p = new Phone();
                p.ID = (int)item["ID"];
                p.ProductName = item["ProductName"].ToString();
                p.Price = (decimal)item["Price"];
                p.IMEI1 = item["IMEI1"].ToString();
                p.IMEI2 = item["IMEI2"].ToString();
                p.ModelCode = item["ModelCode"].ToString();//null referans hatası almamak için öncelikle new ile brand oluşturduk
                p.Brand = new Brand();
                p.Brand.BrandName = item["BrandName"].ToString();
                p.Brand.ID = (int)item["BID"];// BURADAKİ BID sqlde brandid yazımıyla aynı olmalı
                p.StockCount = (int)item["StockCount"];
                List.Add(p);
            }
            return List;
        }
        public List<PhoneViewModel> GetPhonesForDisplay()
        {
            List<PhoneViewModel> List = new List<PhoneViewModel>();
            //fill the list
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow item in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.No = (int)item["ID"];
                p.Name = item["ProductName"].ToString();
                p.Price = ((decimal)item["Price"]).ToString("C");
                //p.IMEI1 = item["IMEI1"].ToString();
                //p.IMEI2 = item["IMEI2"].ToString();
                p.ModelCode = item["ModelCode"].ToString();               
                p.Brand = item["BrandName"].ToString();
                p.StockCount = (int)item["StockCount"];
                
                List.Add(p);
            }
            return List;
        }
        public void InsertPhone(Phone newPhone)
        {
            //add new phones to db
            //1- yeni telefon ekleyebileceğimiz bir prosedur olsun
            //2- sqlhelper ile prosedure gerekli verileri gönderelim
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "ProductName";//isimler @ dekilerle aynı olmalı
            p1.Value = newPhone.ProductName;//Iphone 8 gbi gelir urun adı 
            SqlParameter p2 = new SqlParameter("Price",newPhone.Price);//farklı bir yol sqlparametersin overloadu
            SqlParameter p3 = new SqlParameter("IMEI1", newPhone.IMEI1);
            SqlParameter P4 = new SqlParameter("IMEI2", newPhone.IMEI2);
            SqlParameter p5 = new SqlParameter("ModelCode", newPhone.ModelCode);
            SqlParameter p6 = new SqlParameter("BrandID", newPhone.Brand.ID);
            SqlParameter p7 = new SqlParameter("StockCount", newPhone.StockCount);
            Program.SqlHelper.ExecuteProc("InsertPhone",p1,p2,p3,P4,p5,p6,p7);// parametrelerin hepsini ekleyebiliriz.
        }
        public void DeletePhones(int phonesId)
        {
            //telefon silebilecek bir prosedur oluştur 
            //sqlhelper kullanarak proseduremyukarıdaki parametremizi gönderelim ki silinsin
            Program.SqlHelper.ExecuteProc("DeletePhone",phonesId);
            //add newphone
        }
        public void AddStockCountPhone(int ID,int Count)
        {
            SqlParameter p1 = new SqlParameter("ID", ID);
            SqlParameter p2 = new SqlParameter("StockCount", Count);
            Program.SqlHelper.ExecuteProc("AddStockPhone", p1, p2);
        }

        public List<PhoneViewModel> SearchPhone(int? BrandId,string ModelCode="")
        {
            List<PhoneViewModel> List = new List<PhoneViewModel>();
            //exec .... 0,'123'
          var dt=  Program.SqlHelper.GetTable("execute SearchPhone " + BrandId + ", '" + ModelCode + "'");
            foreach (DataRow item in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.Brand = item["BrandName"].ToString();
                p.Price = ((decimal)item["Price"]).ToString("C");
                p.No = (int)item["ID"];
                p.ModelCode = item["ModelCode"].ToString();
                p.Name = item["ProductName"].ToString();
                p.StockCount = (int)item["StockCount"];
                List.Add(p);
            }
            return List;
        }
    }
}
