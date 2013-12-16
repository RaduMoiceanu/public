using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace iCodeSystems.ShoppingCart.Communication
{
    [ServiceContract]
    public interface ICartService
    {
        [OperationContract]
        Cart GetCart(string id);

        [OperationContract]
        void SaveCart(Cart cart);
    }
}
