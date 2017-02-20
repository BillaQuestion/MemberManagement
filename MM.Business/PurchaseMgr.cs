using Dayi.Data.Domain.Seedwork.Specification;
using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public class PurchaseMgr : IPurchaseMgr
    {
        IPurchaseRepository _purchaseRepository;
        public PurchaseMgr(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        /// <summary>
        /// 保存购买记录对象
        /// </summary>
        public void Save(Purchase purchase)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(purchase,
                new ValidationContext(purchase),
                results);
            if (isValid)
                throw new ArgumentException("购买记录数据不合法！");

            if (purchase.IsTransient())
            {
                purchase.GenerateNewIdentity();
                _purchaseRepository.Add(purchase);
            }
            else
                _purchaseRepository.Modify(purchase);

            _purchaseRepository.UnitOfWork.Commit();
        }

        IEnumerable<Purchase> IPurchaseMgr.GetAll()
        {
            return _purchaseRepository.GetAll();
        }

        IEnumerable<Purchase> IPurchaseMgr.GetByDomain(string domain)
        {
            var result = new List<Purchase>();


            ISpecification<Purchase> spec = null;


            switch (domain)
            {
                case "day":
                    spec = new DirectSpecification<Purchase>(p => (DateTime.Now.Day - p.PurchaseDate.Day) < 1);
                    break;
                case "month":
                    spec = new DirectSpecification<Purchase>(p => (DateTime.Now.Month - p.PurchaseDate.Month) < 1);
                    break;
                case "year":
                    spec = new DirectSpecification<Purchase>(p => (DateTime.Now.Year - p.PurchaseDate.Year) < 1);
                    break;
                default: throw new ArgumentException("domain could ontly be one of day, month or year.");
            }
            result = _purchaseRepository.FindBySpecification(spec).ToList();
            return result;
        }

        IEnumerable<MemberPurchase> IPurchaseMgr.GetByMember(Guid memberId)
        {
            //ISpecification<MemberPurchase> spec = new DirectSpecification<MemberPurchase>(p => p.MemberId == memberId);
            //return _purchaseRepository.FindBySpecification(spec).ToList();
            return null;
        }
    }
}
