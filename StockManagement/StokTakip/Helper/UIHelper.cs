﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
   static class UIHelper
    {
        static UnitOfWork _uw = new UnitOfWork();
        public static void FillBrandComboBox(ComboBox cb,string firstOption)
        {
            cb.DisplayMember = "BrandName";
            cb.ValueMember = "ID";
            var List = _uw.BrandRepo.GetBrands();
            Brand b = new Brand() { ID = 0, BrandName = firstOption };
            List.Insert(0, b);
            cb.DataSource = List;
        }
    }
}
