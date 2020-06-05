using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public class Store : IStore
    {
        #region Properties
        public Category Category { get; set; }
        #endregion

        #region Constructors
        public Store()
        {

        }
        #endregion

        #region Functions
        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
