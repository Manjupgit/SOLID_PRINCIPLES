using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Core.ISPBroken
{
    //ISP is broken as process method is not required by
    //OfflineOrder class but is forced to implement.
  
        public interface IOrder
        {
            void AddToCart();
            void CCProcess();
        }

        public class OnlineOrder : IOrder
        {
        public OnlineOrder()
        {
            Console.WriteLine("Online Order Processing...");
        }
            public void AddToCart()
            {
                Console.WriteLine("Do Add to Cart"); 
            }

            public void CCProcess()
            {
                Console.WriteLine("process through credit card"); 
            }
        }

        public class OfflineOrder : IOrder
        {
        public OfflineOrder()
        {
            Console.WriteLine("Offline Order Processing...");

        }
        public void AddToCart()
            {
                Console.WriteLine("Do Add to Cart");
            }

            public void CCProcess()
            {
                //Not required for Cash/ offline Order
                throw new NotImplementedException();
            }
        }

    
}
