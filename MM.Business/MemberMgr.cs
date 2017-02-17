using Dayi.Data.Domain.Seedwork.Specification;
using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    internal class MemberMgr : IMemberMgr
    {
        IMemberRepository _memberRepository;
        IBalanceRepository _balanceRepository;

        public MemberMgr(IMemberRepository memberRepository, IBalanceRepository balanceRepository)
        {
            _memberRepository = memberRepository;
            _balanceRepository = balanceRepository;
        }

        /// <summary>
        /// 保存Member对象
        /// </summary>
        public void Save(Member member)
        {
            if (member.IsTransient())
            {
                member.GenerateNewIdentity();
                _memberRepository.Add(member);
            }
            else
            {
                _memberRepository.Modify(member);
                foreach (var balance in member.Balances)
                {
                    if (balance.IsTransient())
                    {
                        balance.GenerateNewIdentity();
                        _balanceRepository.Add(balance);
                    }
                    else
                        _balanceRepository.Modify(balance);
                }
            }

            _memberRepository.UnitOfWork.Commit();
        }

        /// <summary>
        /// 根据手机号码查找会员
        /// </summary>
        /// <param name="phoneNumber">手机号码</param>
        /// <returns>会员对象</returns>
        public Member FindByPhoneNumber(string phoneNumber)
        {
            ISpecification<Member> spec = new DirectSpecification<Member>(m => m.PhoneNumber == phoneNumber);
            return _memberRepository.FindBySpecification(spec).FirstOrDefault();
        }

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
