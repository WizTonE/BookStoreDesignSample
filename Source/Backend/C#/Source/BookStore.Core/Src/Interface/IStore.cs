using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public interface IStore
    {
        void CheckIn();
        void CheckOut();
    }
}