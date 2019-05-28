using System.Collections.Generic;
using System.ServiceModel;

namespace ProductInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IWCFProductService
    {
        [OperationContract]
        List<string> ListProducts();//**dummie**request a list of product from service
    }
}
