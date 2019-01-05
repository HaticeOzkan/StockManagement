using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class SqlHelper
    {//statik instance sini alıp her yerde ona göre alırsın
        private string ConnectionString { get; set; }
        private SqlConnection Connection { get; set; }
        public SqlHelper()
        {
            ConnectionString = @"server=DESKTOP-SPE8JET\SQLEXPRESS; database=StockManagement; user id=funda;integrated security=true; ";
            Connection = new SqlConnection(ConnectionString);
        }
        public int ExecuteCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            int r = command.ExecuteNonQuery();
            Connection.Close();
            return r;//kaç satır eklendiyse satır sayısını aldık
        }
        public void ExecuteProc(string procName,int? Id=null)//proseduru alıcaz sqldeki
        {// bu methodu bir çok prosedur için kullanacam id lazım olabilirde olmayabilirde null aptım id koysakda koymasakta olur parametre alabilirzde almayabilirizde
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;//komutu çalıştırıyo 
            command.CommandText = procName;
            if (Id.HasValue)
                command.Parameters.AddWithValue("ID", Id.Value);// sqldeki id ile aynı yazılması önemli
                //obsolete görürsen bunu microsoft yakınzmanda kaldırabilir onun yerine önerdiği şeyi kullanalım
           // command.Parameters.Add("ID", Id.Value);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public void ExecuteProc(string procName,params SqlParameter[] ps)//overload unu yapıyoz// sayısı farketmezksisizn farklı sayılarda parametre göndermek istiyorsak bazen 3 bazen 5 yollayabiliriz yukarıya opsiyonel olarak ekleyebiliriz.
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps);//  tum parametreyi foreach siz direk ekledik
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public DataTable GetTable(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
      
    }

}
