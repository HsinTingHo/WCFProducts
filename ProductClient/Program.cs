using ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ProductClient.ServiceReference1;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace ProductClient
{
    class Program
    {

        public static object Tread { get; private set; }

        public static CallResponseOfArrayOfPartWithQuantityResult4MCb5AyH checkDropShip(OrderingsvcClient proxy, UserInformation user, string partNumber, int quantity)
        {
            ServiceReference1.PartWithQuantityRequest partWithQuantityReq = new PartWithQuantityRequest();
            partWithQuantityReq.PartNumber = partNumber;
            partWithQuantityReq.Quantity = quantity;

            ServiceReference1.CheckDropShipAvailabilityRequest dropShipReq = new ServiceReference1.CheckDropShipAvailabilityRequest();
            dropShipReq.PartsWithQuantity = new ServiceReference1.PartWithQuantityRequest[1];
            dropShipReq.PartsWithQuantity[0] = partWithQuantityReq;
            dropShipReq.UserRequestInfo = user;
            ServiceReference1.CallResponseOfArrayOfPartWithQuantityResult4MCb5AyH dropShipAvailitilityRes = proxy.CheckDropShipAvailability(dropShipReq);
            Thread.Sleep(4000);
            return dropShipAvailitilityRes;
        }
        
        //public static OrderLineItem setOrderLineItems
        public static CallResponseOfOrderingResponse4MCb5AyH order(OrderingsvcClient proxy, UserInformation user, List<OrderLineItem> orderLineItems)
        {

            CallResponseOfOrderingResponse4MCb5AyH orderRes = new CallResponseOfOrderingResponse4MCb5AyH();
            return orderRes;
        }
        static void Main(string[] args)
        {
            string varificationCode;
           
            //set up proxy
            ServiceReference1.OrderingsvcClient proxy = new ServiceReference1.OrderingsvcClient("BasicHttpBinding_Ordering.svc");

            //set up user info
            ServiceReference1.UserInformation user = new ServiceReference1.UserInformation();
            //user.AccountNumber;
            //user.UserName;
            //user.VerificationCode = new Guid(varificationCode);
            //user.UserPassword;




            ServiceReference1.CallResponseOfArrayOfPartWithQuantityResult4MCb5AyH dropShipAvailitilityRes = checkDropShip(proxy, user, "HO1046101", 2);
            Console.WriteLine("Sent check drop availability request");
            Console.Write("Result: ");
            Console.WriteLine(dropShipAvailitilityRes.Value[0].Quantity);
            Console.ReadLine();
            proxy.Close();
            
        }
    }
}
