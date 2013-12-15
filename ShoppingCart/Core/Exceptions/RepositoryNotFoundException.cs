using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    [Serializable]
    public class RepositoryNotFoundException : Exception
    {
        public string TypeName { get; set; }
        public string FullyQualifiedTypeName { get; set; }

        public RepositoryNotFoundException(string type, string fqTypeName, string messageFormat) : base(String.Format(messageFormat, type, fqTypeName))
        {
            this.TypeName = type;
            this.FullyQualifiedTypeName = fqTypeName;
        }
    }
}
