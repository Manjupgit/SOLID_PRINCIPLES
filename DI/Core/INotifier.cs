using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Core
{
    public interface INotifier
    {
        void Notify(string message);
    }
}
