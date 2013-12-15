using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public class CartRepository : RepositoryBase<ICart>, ICartRepository, IRepository<ICart, string>
    {

        protected override string BuildKey(string id)
        {
            return String.Format("{0}.{1}", typeof(ICart).Name, id);
        }
    }
}
