using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Core
{
    public class SMSNotifier : INotifier
    {
        public void Notify(string message)
        {
            //send notification
        }
    }
}
