using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iCodeSystems.ShoppingCart.Communication;

namespace iCodeSystems.ShoppingCart
{
    public static class ExtensionMethods
    {
        public static Cart ToDataContract(this CartBase cart)
        {
            return Cart.ConvertFromBase(cart);
        }

        public static CartItem ToDataContract(this CartItemBase item)
        {
            return CartItem.ConvertFromBase(item);
        }
    }
}
