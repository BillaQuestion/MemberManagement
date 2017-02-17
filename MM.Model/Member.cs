using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model.Exceptions;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace MM.Model
{
    public class Member : Entity
    {
        private HashSet<Balance> _balances;
        private HashSet<MemberPurchase> _purchaseRecords;
        private HashSet<Consumption> _consumeRecords;

        #region Properties
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 会员卡余额
        /// </summary>  
        public ICollection<Balance> Balances
        {
            get
            {
                if (_balances == null)
                    _balances = new HashSet<Balance>();
                return _balances;
            }
        }

        /// <summary>
        /// 购买记录
        /// </summary>
        public ICollection<MemberPurchase> PurchaseRecords
        {
            get
            {
                if (_purchaseRecords == null)
                    _purchaseRecords = new HashSet<MemberPurchase>();
                return _purchaseRecords;
            }
        }

        /// <summary>
        /// 消费记录
        /// </summary>
        public ICollection<Consumption> ConsumeRecords
        {
            get
            {
                if (_consumeRecords == null)
                    _consumeRecords = new HashSet<Consumption>();
                return _consumeRecords;
            }
        }
        #endregion

        #region Public Methods
 
        public Consumption Consume(Guid memberProductId, Guid tutorId, out Balance balance)
        {
            balance = _balances.FirstOrDefault(x => x.MemberProductId == memberProductId);
            if (balance == null) throw new BalanceNotEnoughException();
            balance.Remainder--;
            Consumption consumption = new Consumption()
            {
                TutorId = tutorId,
                MemberProduct = balance.Product
            };
            _consumeRecords.Add(consumption);
            if (balance.Remainder == 0) _balances.Remove(balance);
            return consumption;
        }

        public Consumption Consume(Guid memberProductId, Guid tutorId, string sessionDescription, out Balance balance)
        {
            balance = _balances.FirstOrDefault(x => x.MemberProductId == memberProductId);
            if (balance == null) throw new BalanceNotEnoughException();
            balance.Remainder--;
            if (!(balance.Product is Lecture)) throw new ValidationException();
            Session session = new Session()
            {
                TutorId = tutorId,
                MemberProduct = balance.Product,
                Description = sessionDescription
            };
            _consumeRecords.Add(session);
            if (balance.Remainder == 0) _balances.Remove(balance);
            return session;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(PhoneNumber))
                result.Add(new ValidationResult("PhoneNumber必须赋值！", new string[] { "PhoneNumber" }));
            return result;
        }


        #endregion
    }
}
