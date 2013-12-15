using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    public interface IRepository<TEntity, in TKey> where TEntity : IIdentifyable
    {
        /// <summary>
        /// Gets from the data repository the object with the specified identifier
        /// </summary>
        /// <param name="id">Identifier of object to read from the data repository</param>
        /// <returns>The instance of the object</returns>
        TEntity Get(TKey id);

        /// <summary>
        /// Saves the object to the data repository
        /// </summary>
        /// <param name="entity">The object to save</param>
        void Save(TEntity entity);

        /// <summary>
        /// Deletes the object from the data repository
        /// </summary>
        /// <param name="entity">The object to save</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes the object with the specified identifier from the data repository
        /// </summary>
        /// <param name="id">Identifier of object to delete from the data repository</param>
        void Delete(TKey id);
    }
}
