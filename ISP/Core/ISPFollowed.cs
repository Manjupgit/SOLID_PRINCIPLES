using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Core.ISPFollowd
{
  
        public interface IOrder
        {
            void AddToCart();
        }

        public interface IOnlineOrder
        {
            void CCProcess();
        }

        public class OnlineOrder : IOrder, IOnlineOrder
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
        }
    
}
