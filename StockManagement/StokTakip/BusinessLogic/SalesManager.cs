﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
   public class SalesManager
    {
        public static DataTable GetProducts(string q=null)
        {
            if (q == null)
                return Program.SqlHelper.GetTable(@"exec GetAvailableProduct");
            else
                return Program.SqlHelper.GetTable(@"exec GetAvailableProduct '" + q + "'");

           
        }
        public static void SellProducts(List<Product> products)
        {
            foreach (var item in products)
                if (item is Phone)
                    SellPhone(item);
                else if (item is PhoneCase)
                    SellPhonecase(item);
        }
        private static void SellPhonecase(Product item)
        {
            Program.SqlHelper.ExecuteCommand("UPDATE PhoneCases SET StockCount = StockCount- 1 WHERE ID = " + item.ID);
        }

        private static void SellPhone(Product item)
        {
            Program.SqlHelper.ExecuteCommand("UPDATE Phones SET StockCount = StockCount - 1 WHERE ID = " + item.ID);
        }
    }
}
