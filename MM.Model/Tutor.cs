using MM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dayi.Data.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace MM.Model
{
    public class Tutor : Entity
    {
        public string Name { get; set; }

        public string Password { get; private set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsManager { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (string.IsNullOrEmpty(Name))
                result.Add(new ValidationResult("Name必须赋值！", new string[] { "Name" }));
            return result;
        }

        /// <summary>
        /// 向会员销售
        /// </summary>
        /// <returns>购买记录</returns>
        public Purchase Sell(MemberProduct product, Member member)
        {
            // 1、新建一个购买记录
            MemberPurchase purchase = new MemberPurchase()
            {
                Member = member,
                MemberId = member.Id,
                Product = product,
                Tutor = this,
            };

            // 2、增加会员的产品余额
            var balance = member.Balances.FirstOrDefault(x => x.Product.Name == product.Name);
            if (balance == null)
            {
                balance = new Balance()
                {
                    Product = product,
                    Remainder = product.Count
                };
                member.Balances.Add(balance);
            }
            else
            {
                balance.Remainder = balance.Remainder + product.Count;
            }

            return purchase;
        }

        /// <summary>
        /// 销售一次性体验产品
        /// </summary>
        /// <param name="product">所销售产品</param>
        /// <returns>购买记录</returns>
        public Purchase Sell(OneTimeExperience product)
        {
            Purchase purchase = new Purchase()
            {
                Product = product,
                Tutor = this,
                PurchaseDate = DateTime.Now
            };
            return purchase;
        }

        /// <summary>
        /// 设置密码
        /// </summary>
        /// <param name="password">密码</param>
        public void SetPassword(string password)
        {
            Password = GetPasswordHashCode(password);
        }

        /// <summary>
        /// 利用密码验证身份
        /// </summary>
        /// <param name="password">所需要验证的密码</param>
        /// <returns>通过验证时，返回true；否则返回false。</returns>
        public bool Authenticate(string password)
        {
            if (Password == GetPasswordHashCode(password))
                return true;
            else
                return false;
        }

        private string GetPasswordHashCode(string password)
        {
            // 1、计算password的哈希值
            byte[] hashCode = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(password));
            return Encoding.UTF8.GetString(hashCode);
        }
    }
}