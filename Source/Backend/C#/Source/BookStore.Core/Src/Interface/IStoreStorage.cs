﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public interface IStoreStorage
    {
        Store GetStore(IStoreStorage store);
    }
}
