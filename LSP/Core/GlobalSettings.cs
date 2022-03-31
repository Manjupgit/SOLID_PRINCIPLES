using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Core
{
    //Violates LSP
    //public class GlobalSettings : ISettings
    //With LSP DESIGN
    public class GlobalSettings : IReadableSettings,IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("Theme", "Summer");
            return settings;
        }

        //Called by Save Method.
        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }
            return "Global settings saved on " + DateTime.Now;
        }
    }
}
