using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart.Communication
{
    [DataContract]
    public class Cart : ICart
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember(Name="Items")]
        private IEnumerable<CartItem> _items;
        public List<ICartItem> Items 
        {
            get { return (List<ICartItem>)_items; }
            set { _items = value.ConvertAll<CartItem>(new Converter<ICartItem, CartItem>(CartItem.ConvertFromBase)); }
        }

        [DataMember]
        public List<string> PromotionCodes { get; set; }


        public static implicit operator CartBase(Cart cart)
        {
            return ConvertToBase(cart);
        }


        public static CartBase ConvertToBase(Cart cart)
        {
            return new CartBase()
            {
                Id = cart.Id,
                Items = (List<ICartItem>)cart.Items,
                PromotionCodes = cart.PromotionCodes
            };
        }

        public static Cart ConvertFromBase(ICart cart)
        {
            return new Cart()
            {
                Id = cart.Id,
                Items = (List<ICartItem>)cart.Items,
                PromotionCodes = cart.PromotionCodes
            };
        }
    }
}
