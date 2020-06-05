using AutoMapper;
using BookStore.Core;
using BookStore.Model;
using BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public class Member : IMember
    {
        #region Properties
        IMemberRepository MemberRepository { get; set; }
        IMapper mapper { get; set; }
        public string AccountID { get; set; }
        public string Password { get; set; }
        public MemberInfo MemberInfo { get; set; }
        #endregion

        #region Constructors
        public Member(IMemberRepository memberRepository)
        {
            MemberRepository = memberRepository;
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Member, MemberUdt>();
            });
            mapper = configuration.CreateMapper();
        }
        #endregion

        #region Functions
        public MemberInfo Login(Member member)
        {
            var memberUdt = mapper.Map<MemberUdt>(member);
            MemberInfo = MemberRepository.Login(memberUdt);
            return MemberInfo;
        }

        public void Pickup(Book book)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
