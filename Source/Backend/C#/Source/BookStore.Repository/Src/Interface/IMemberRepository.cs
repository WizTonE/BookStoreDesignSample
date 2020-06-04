using BookStore.Model;
using System.Data;

namespace BookStore.Repository
{
    public interface IMemberRepository
    {
        MemberInfo Login(MemberUdt member);
    }
}