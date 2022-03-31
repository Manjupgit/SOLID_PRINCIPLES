using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Core
{
    //Violates LSP
    //public class GuestSettings : ISettings
    //By Following LSP
    public class GuestSettings : IReadableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("GuestName", "John");
            return settings;
        }

        //Here Guest User dont have previliges to update or set Settings. 
        // This is a violation of LSP.Added two interfaces to the Core folder —IReadableSettings and IWritableSettings.
        //This is not required when we implment IReadableSettings as it contains only one Method.   
        public string SetSettings(Dictionary<string, string> settings)
        {
            throw new NotImplementedException();
        }
    }
}
