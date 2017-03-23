using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model;
using MM.Model.IRepositories;
using Dayi.Data.Domain.Seedwork.Specification;
using System.ComponentModel.DataAnnotations;

namespace MM.Business
{
    public class MemberCardMgr : IMemberCardMgr
    {
        IMemberCardRepository _memberCardRepository;

        public MemberCardMgr(IMemberCardRepository memberCardRepository)
        {
            _memberCardRepository = memberCardRepository;
        }
        MemberCard IMemberCardMgr.GetById(Guid memberCardId)
        {
            return _memberCardRepository.GetByKey(memberCardId);
        }

        void IMemberCardMgr.Save(MemberCard balance)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(balance,
                new ValidationContext(balance),
                results);
            if (!isValid)
                throw new ArgumentException("余额数据不合法！");

            if (balance.Remainder == 0)
            {
                _memberCardRepository.Remove(balance);
            }
            else
            {
                if (balance.IsTransient())
                {
                    balance.GenerateNewIdentity();
                    _memberCardRepository.Add(balance);
                }
                else
                    _memberCardRepository.Modify(balance);
            }
            _memberCardRepository.UnitOfWork.Commit();
        }
    }
}