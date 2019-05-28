using ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace productService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in both code and config file together.
    public class WCFProductService : IWCFProductService
    {
        public List<string> ListProducts()
        {
            Console.WriteLine("ListProducts() has been called by a client");
            List<string> productsList = new List<string>() { "product1" };
            try
            {
                Console.WriteLine("Try to do nothing!");
            }
            catch
            {
                Console.WriteLine("fail to initialize productsList");
            }
        
                //Code to connect to the database illustrated in the video
                //using(adventureworkEntities database = new adventrueworksEntities())
           
         
            return productsList;
        }
    }
}
