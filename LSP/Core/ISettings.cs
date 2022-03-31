using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Core
{
    //This is not adhere to LSP, It will create issue when Guest User Trying to Use the interface.
    //This is a violation of LSP.Let's correct the error by creating 
    // two interfaces to the Core folder— IReadableSettings and IWritableSettings. instead of this interface.
    public interface ISettings
    {
        Dictionary<string, string> GetSettings();
        string SetSettings(Dictionary<string, string> settings);
    }
}
