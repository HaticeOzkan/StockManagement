using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
  public abstract class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
    class Phone : Product
    {
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public Brand Brand { get; set; }
        public string ModelCode { get; set; }    
        public int StockCount { get; set; }
        
    }
    class Brand
    {
        public int ID { get; set; }
        public string BrandName { get; set; }

    }
    class PhoneCase : Product
    {
       public CaseColor CaseColor { get; set; }
        public int StockCount { get; set; }
    }

    enum CaseColor//2 den fazla tutmak istersek tablo tutmak daha mantıklı 
    {[Description("Siyah")]//c# ın attributeleri bunu Diller Açısından cevirsin diye yaptık // enumın nasıl yazıldığını komple t değişkenine attım yazımla alakalı herşeyi biliyo bu refleksın sınıf sayesınde biliyor köşeli parantezin hemen altındakiler ilişikli biliyor 
        Black,
      [Description("Altın")]
        Gold,
        [Description("Pembe")]
        Pink,
        [Description("Kırmızı")]
        Red,
        [Description("Mor")]
        Purple
    }
}
