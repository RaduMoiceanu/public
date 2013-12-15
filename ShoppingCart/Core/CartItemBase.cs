using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    /// <summary>
    /// Item from the shopping cart
    /// </summary>
    [Serializable]
    public class CartItemBase : ICartItem
    {
        /// <summary>
        /// Identifier used to uniquely identify each item in cart
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// SKU of subitem
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Quantity of item
        /// </summary>
        public int Quantity { get; set; }
    }
}
