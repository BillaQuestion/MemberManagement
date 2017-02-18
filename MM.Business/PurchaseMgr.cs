using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
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
            if (purchase.IsTransient())
            {
                purchase.GenerateNewIdentity();
                _purchaseRepository.Add(purchase);
            }
            else
                _purchaseRepository.Modify(purchase);

            _purchaseRepository.UnitOfWork.Commit();
        }
    }
}
