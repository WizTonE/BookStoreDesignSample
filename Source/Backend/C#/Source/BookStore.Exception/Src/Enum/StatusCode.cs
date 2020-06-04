using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BookStore.Exception.Src
{
    public enum StatusCode
    {
        [Description("Success")]
        COMM0000,
        [Description("Network Error")]
        COMM0201,
        [Description("Database Error")]
        SQDB9999,
        [Description("Unknown Error")]
        EORR9999

    }
}
