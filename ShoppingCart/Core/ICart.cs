using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    /// <summary>
    /// The shopping cart used by the eCommerce sites
    /// </summary>
    public interface ICart : IIdentifyable
    {
        /// <summary>
        /// List of items contained by the shopping cart
        /// </summary>
        List<ICartItem> Items { get; set; }

        /// <summary>
        /// Promotion codes applied by the user
        /// </summary>
        List<string> PromotionCodes { get; set; }
    }
}
