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
    public interface ICartItem : IIdentifyable
    {
        /// <summary>
        /// SKU of subitem
        /// </summary>
        string Sku { get; set; }

        /// <summary>
        /// Quantity of item
        /// </summary>
        int Quantity { get; set; }
    }
}
