using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Core
{
    public interface IWritableSettings
    {
        string SetSettings(Dictionary<string, string> settings);
    }
}
