using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace productService
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Starts!");
            
            using (ServiceHost host = new ServiceHost(typeof(WCFProductService)))
            {
                host.Open();//Open our host to allow other people to connect
                Console.WriteLine("Server is open");
                Console.WriteLine("Press enter to close server");
                Console.ReadLine(); //to wait for user input

            }
        }
    }
}
