using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace StokTakip
{
    enum Languages
    {
        en,
        tr
    }
  static  class Setting
    {
       
        public static void ChangeLanguage(Languages lang)
        {
            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var json = jss.Serialize(lang);
            File.WriteAllText("settings.json", json);
        }
        public static void GetLatesLanguage()
        {
            Languages Lang = Languages.tr;
            if (File.Exists("settings.json"))
            {
                var SettingContent = File.ReadAllText("settings.Json");
                JavaScriptSerializer jss = new JavaScriptSerializer();
                jss.Deserialize<Languages>(SettingContent);
            }
            CultureInfo.CurrentCulture = new CultureInfo(Lang.ToString());
            CultureInfo.CurrentUICulture=new CultureInfo(Lang.ToString());
        }
    }
}
