using Dayi.Data.Domain.Seedwork.Specification;
using MM.Model;
using MM.Model.Exceptions;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MM.Business
{
    public class MemberMgr : IMemberMgr
    {
        IMemberRepository _memberRepository;

        public MemberMgr(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        /// <summary>
        /// 保存Member对象
        /// </summary>
        public void Save(Member member)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(member,
                new ValidationContext(member),
                results);
            if (!isValid)
                throw new ArgumentException("会员数据不合法！");

            if (member.IsTransient())
            {
                member.GenerateNewIdentity();
                _memberRepository.Add(member);
            }
            else
            {
                _memberRepository.Modify(member);
            }
            _memberRepository.UnitOfWork.Commit();
        }

        IEnumerable<Member> IMemberMgr.GetAll()
        {
            return _memberRepository.GetAll();
        }


        /// <summary>
        /// 根据手机号码查找会员
        /// </summary>
        /// <param name="phoneNumber">手机号码</param>
         /// <returns>会员对象</returns>
       Member IMemberMgr.GetByPhoneNumber(string phoneNumber)
        {
            ISpecification<Member> spec = new DirectSpecification<Member>(m => m.PhoneNumber == phoneNumber);
            return _memberRepository.FindBySpecification(spec).FirstOrDefault();
        }

        void IMemberMgr.Modify(Member member)
        {
            if (member.IsTransient())
                throw new MemberNotExistException("会员不存在！");

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

