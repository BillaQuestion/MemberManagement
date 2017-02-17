using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model.IRepositories;
using MM.Model;
using Dayi.Data.Domain.Seedwork.Specification;
using MM.Business.Exceptions;
using MM.Model.Enums;

namespace MM.Business
{
    public class MemberMgr : IMemberMgr
    {
        private IMemberRepository _memberRepository;

        public MemberMgr(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        IEnumerable<Member> IMemberMgr.GetAll()
        {
            return _memberRepository.GetAll();
        }

        Member IMemberMgr.Get(string phoneNumber)
        {
            ISpecification<Member> spec = new DirectSpecification<Member>(m => m.PhoneNumber == phoneNumber);
            return _memberRepository.FindBySpecification(spec).FirstOrDefault();
        }

        void IMemberMgr.Create(string name, string phoneNumber, Gender gender, string address, Balance balance)
        {
            var member = new Member(balance)
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Gender = gender,
                Address = address
            };
            if (member.IsTransient())
                member.GenerateNewIdentity();
            _memberRepository.Add(member);

            _memberRepository.UnitOfWork.Commit();
        }

        void IMemberMgr.Modify(Member member)
        {
            if (member.IsTransient())
            {
                member.GenerateNewIdentity();
                _memberRepository.Add(member);
            }
            else
                _memberRepository.Modify(member);
            _memberRepository.UnitOfWork.Commit();
        }

        void IMemberMgr.Remove(Guid memberId)
        {
            var result = _memberRepository.GetByKey(memberId);
            if (result == null)
                throw new MemberNotExistException();
            else
                _memberRepository.Remove(result);

            _memberRepository.UnitOfWork.Commit();
        }
    }
}