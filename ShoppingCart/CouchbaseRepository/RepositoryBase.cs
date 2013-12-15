using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couchbase;
using Couchbase.Extensions;
using Enyim.Caching.Memcached;
using Enyim.Caching.Memcached.Results;
using Newtonsoft.Json;

namespace iCodeSystems.ShoppingCart
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity, string> where TEntity : IIdentifyable
    {
        protected static CouchbaseClient _Client { get; set; }
        static RepositoryBase()
        {
            _Client = new CouchbaseClient();
        }


        public virtual TEntity Get(string id)
        {
            var doc = _Client.Get<TEntity>(BuildKey(id));

            return doc;
        }

        public virtual void Save(TEntity entity)
        {
            //var result = _Client.Cas(StoreMode.Set, BuildKey(entity), entity);            
            //return result.Result ? result.Cas : 0;

            string storeKey = BuildKey(entity);

            IStoreOperationResult result = _Client.ExecuteStore(StoreMode.Set, storeKey, entity);
            if (!result.Success)
                throw result.Exception;
        }

        public virtual void Delete(TEntity entity)
        {
            _Client.Remove(BuildKey(entity));
        }

        public virtual void Delete(string id)
        {
            _Client.Remove(BuildKey(id));
        }


        protected abstract string BuildKey(string id);
        protected virtual string BuildKey(TEntity entity)
        {
            return BuildKey(entity.Id);
        }
    }
}
