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

        void IMemberCardMgr.Save(MemberCard memberCard)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(memberCard,
                new ValidationContext(memberCard),
                results);
            if (!isValid)
                throw new ArgumentException("会员卡数据不合法！");

            if (memberCard.Remainder == 0)
            {
                _memberCardRepository.Remove(memberCard);
            }
            else
            {
                if (memberCard.IsTransient())
                {
                    memberCard.GenerateNewIdentity();
                    _memberCardRepository.Add(memberCard);
                }
                else
                    _memberCardRepository.Modify(memberCard);
            }
            _memberCardRepository.UnitOfWork.Commit();
        }
    }
}