using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public class Store : IStore
    {
        #region Fields
        private static IDictionary<IStoreStorage, Store> _pool;
        #endregion

        #region Properties
        public List<Member> Members { get; set; }
        public Category Category { get; set; }
        protected static IDictionary<IStoreStorage, Store> Pool => _pool ?? (_pool = new Dictionary<IStoreStorage, Store>());
        #endregion

        #region Constructors
        public Store()
        {

        }
        #endregion

        #region Functions
        public static Store GetStore(IStoreStorage store)
        {
            if (!Pool.ContainsKey(store))
                Pool.Add(store, new Store());
            return Pool[store];
        }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
