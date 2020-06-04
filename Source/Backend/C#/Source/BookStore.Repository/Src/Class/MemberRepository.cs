using BookStore.Exception.Src;
using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberInfo Login(MemberUdt member)
        {
            return BookStoreException.TryThrow<MemberInfo>(() => 
            {
                return new MemberInfo();
            });
        }
    }
}
