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

        IEnumerable<Member> IMemberMgr.GetAllMembers()
        {
            return _memberRepository.GetAll();
        }

        Member IMemberMgr.GetMember(string phoneNumber)
        {
            ISpecification<Member> spec = new DirectSpecification<Member>(m => m.PhoneNumber == phoneNumber);
            return _memberRepository.FindBySpecification(spec).FirstOrDefault();
        }

        void IMemberMgr.AddMember(string name, string phoneNumber, Gender gender, string address)
        {
            var member = new Member()
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

        void IMemberMgr.ModifyMember(Member member)
        {
            var result = _memberRepository.GetByKey(member.Id);
            if (result == null)
                throw new MemberNotExistException();
            else
                _memberRepository.Modify(member);

            _memberRepository.UnitOfWork.Commit();
        }

        void IMemberMgr.RemoveMember(Guid memberId)
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