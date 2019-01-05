using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class BrandRepo
    {
        public List<Brand> GetBrands()//verileri listeye cevirsin
        {
            List<Brand> List = new List<Brand>();
            //fill the list
            DataTable dt = Program.SqlHelper.GetTable("select * from brands");
            // her satır bir nesne aldığımız satırları nesnelere donusturecez
            foreach (DataRow row in dt.Rows)
            {
                //unboxing işlemi yaptık kast ederken tam tersi
                Brand b = new Brand();
                b.ID = (int)row["BrandID"];//UNBOXİNG
                b.BrandName = row["BrandName"].ToString();
                List.Add(b);//datarow ve this.controls datagrid bunlarda belirt var diyip bırakma
            }
                       
            return List;
        }
        public void InsertBrand(Brand newBrand)
        {//@ ler aşağı satıra gecmemizi sağlar tekrar koyduk
            Program.SqlHelper.ExecuteCommand(@"
if not exists(select * from brands where BrandName='"+newBrand.BrandName+@"')
insert into brands (BrandName) values ('" + newBrand.BrandName + "')");
        }
        // gelen id yi markalardan silen bir prosedur oluşturduk database de
        public void DeleteBrand(int brandId)
        {
            Program.SqlHelper.ExecuteProc("DeleteBrand",brandId);//ya overload edelim yada opsiyonel bir parametre ekleyelim
            //delete brand from database
        }
    }
}
