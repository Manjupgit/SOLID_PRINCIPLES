using System;

namespace ISP
{
    class Program
    {
        //This is a Console App,
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Broken Interface Segrigation Principle");
            Console.ForegroundColor = ConsoleColor.White;
            Core.ISPBroken.OnlineOrder order = new Core.ISPBroken.OnlineOrder();

            order.AddToCart();
            order.CCProcess();

            Core.ISPBroken.OfflineOrder offOrder = new Core.ISPBroken.OfflineOrder();
            offOrder.AddToCart();
            try{
                offOrder.CCProcess(); // THis trows Exception when uncommented still you can continue. 
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception in Offline Order Process : Processing Credit Card - " + ex.Message + "\n"  + ex.StackTrace);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("=================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Followed Interface Segrigation Principle");
            Console.ForegroundColor = ConsoleColor.White;
            Core.ISPFollowd.OnlineOrder orderLSP = new Core.ISPFollowd.OnlineOrder();
            orderLSP.AddToCart();
            orderLSP.CCProcess();

            Core.ISPFollowd.OfflineOrder offlOrderLSP = new Core.ISPFollowd.OfflineOrder();
            offlOrderLSP.AddToCart();
            //IT doesnot have another method to call since the Interface have only one Method to impl.

        }
    }
}
