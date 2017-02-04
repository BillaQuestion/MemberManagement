using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model.Exceptions;

namespace MM.Model
{
    public class Member
    {
        private ICollection<Balance> _balances;
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
        public ICollection<Purchase> PurchaseRecords { get; set; }

        /// <summary>
        /// 消费记录
        /// </summary>
        public ICollection<Consumption> ConsumeRecords { get; set; }
        #endregion

        #region Public Methods
        public void AddProduct(MemberProduct memberProduct)
        {
            
            var result = _balances.FirstOrDefault(x => x.MemberProduct.Name == memberProduct.Name);
            if (result == null)
            {
                Balance balance = new Balance();
                balance.MemberProduct = memberProduct;
                balance.Remainder = memberProduct.Count;
                _balances.Add(balance);
            }
            else
            {
                result.Remainder = result.Remainder + memberProduct.Count;
            }
        }

        public void UseBalance(string productName)
        {
            var result = _balances.FirstOrDefault(x => x.MemberProduct.Name == productName);
            if(result == null)
            {
                throw new ProductNotExistException();
            }
            result.Remainder--;
            if (result.Remainder == 0)
            {

            }
        }
        #endregion
    }
}
