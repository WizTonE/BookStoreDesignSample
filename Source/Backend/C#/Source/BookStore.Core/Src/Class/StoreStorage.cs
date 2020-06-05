using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public class StoreStorage : IStoreStorage
    {
        #region Fields
        private static IDictionary<IStoreStorage, Store> _pool;
        private static StoreStorage _default;
        #endregion

        #region Properties
        public List<Member> Members { get; set; }
        public StoreStorage Default => _default ?? (_default = new StoreStorage());
        protected static IDictionary<IStoreStorage, Store> Pool => _pool ?? (_pool = new Dictionary<IStoreStorage, Store>());
        #endregion

        #region Functions
        public Store GetStore(IStoreStorage store)
        {
            if (!Pool.ContainsKey(store))
                Pool.Add(store, new Store());
            return Pool[store];
        }
        #endregion
    }
}
