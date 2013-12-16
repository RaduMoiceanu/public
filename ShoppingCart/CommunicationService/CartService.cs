using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace iCodeSystems.ShoppingCart.Communication
{
    public class CartService : ICartService
    {
        public Cart GetCart(string id)
        {
            return (DataServiceProvider<ICart>.Repository.Get(id) as CartBase).ToDataContract();
        }

        public void SaveCart(Cart cart)
        {
            if (cart == null)
                throw new ArgumentNullException("composite");

            DataServiceProvider<ICart>.Repository.Save(cart);
        }
    }
}
