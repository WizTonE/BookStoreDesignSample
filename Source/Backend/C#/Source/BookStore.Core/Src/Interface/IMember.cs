using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public interface IMember
    {
        MemberInfo Login(Member member);
    }
}
