using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart.Communication
{
    [DataContract]
    public class CartItem : ICartItem
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Sku { get; set; }

        [DataMember]
        public int Quantity { get; set; }


        public static implicit operator CartItemBase(CartItem item)
        {
            return ConvertToBase(item);
        }


        internal static CartItem ConvertFromBase(ICartItem item)
        {
            return new CartItem()
            {
                Id = item.Id,
                Sku = item.Sku,
                Quantity = item.Quantity,
            };
        }

        internal static CartItemBase ConvertToBase(CartItem item)
        {
            return new CartItemBase()
            {
                Id = item.Id,
                Sku = item.Sku,
                Quantity = item.Quantity,
            };
        }
    }
}
