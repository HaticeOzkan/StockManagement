using StokTakip.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    static class Program
    {
        //nesneyi bir kere ürettim her yerde kullanırım yada herşeyi statik yapıcam 
        //burada program.sqlhelper. diye ulaşacam
        public static SqlHelper SqlHelper = new SqlHelper();
        
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Setting.GetLatesLanguage();
            Application.Run(new Form1());
        }
    }
}
