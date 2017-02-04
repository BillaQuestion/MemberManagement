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
        private ICollection<Balance> _balances;
        private ICollection<Purchase> _purchaseRecords;
        private ICollection<Consumption> _consumeRecords;

        #region Properties
        public String Name { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public String Address { get; set; }

        /// <summary>
        /// 会员卡余额
        /// </summary>  
        public ICollection<Balance> Balances { get { return _balances; } }

        /// <summary>
        /// 购买记录
        /// </summary>
        public ICollection<Purchase> PurchaseRecords { get { return _purchaseRecords; } }

        /// <summary>
        /// 消费记录
        /// </summary>
        public ICollection<Consumption> ConsumeRecords { get { return _consumeRecords; } }
        #endregion

        public Member()
        {
            _balances = new List<Balance>();
            _purchaseRecords = new List<Purchase>();
            _consumeRecords = new List<Consumption>();
        }

        #region Public Methods
        public void BuyProduct(Purchase purchase)
        {
            var memberProduct = purchase.Product as MemberProduct;
            var result = _balances.FirstOrDefault(x => x.MemberProduct.Name == memberProduct.Name);
            if (result == null)
            {
                Balance balance = new Balance()
                {
                    MemberProduct = memberProduct,
                    Remainder = memberProduct.Count
                };
                _balances.Add(balance);
            }
            else
            {
                result.Remainder = result.Remainder + memberProduct.Count;
            }
            _purchaseRecords.Add(purchase);
        }

        public void Consume(Balance balance, Tutor tutor)
        {
            balance.Remainder--;
            Consumption consumption = new Consumption()
            {
                Tutor = tutor,
                MemberProduct = balance.MemberProduct
            };
            _consumeRecords.Add(consumption);
            if (balance.Remainder == 0) _balances.Remove(balance);
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
