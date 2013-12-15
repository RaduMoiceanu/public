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
    [Serializable]
    public class CartBase : ICart
    {
        public List<ICartItem> _items = new List<ICartItem>();
        public List<string> _promotionCodes = new List<string>();


        public string Id { get; set; }

        /// <summary>
        /// List of items contained by the shopping cart
        /// </summary>
        public List<ICartItem> Items 
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Promotion codes applied by the user
        /// </summary>
        public List<string> PromotionCodes 
        {
            get { return _promotionCodes; }
            set { _promotionCodes = value; }
        }
    }
}
