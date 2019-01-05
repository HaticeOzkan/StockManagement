using StokTakip.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class UnitOfWork
    {
       public BrandRepo BrandRepo { get; set; }
        public PhoneRepo PhoneRepo { get; set; }
        public PhoneCaseRepo PhoneCaseRepo { get; set; }
       public SalesManager SalesManager { get; set; }


        public UnitOfWork()
        {
            BrandRepo = new BrandRepo();
            PhoneRepo = new PhoneRepo();
            PhoneCaseRepo = new PhoneCaseRepo();
            SalesManager = new SalesManager();
        }
    }
}
