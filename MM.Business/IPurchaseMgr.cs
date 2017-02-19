using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IPurchaseMgr
    {

        /// <summary>
        /// 保存购买记录对象
        /// </summary>
        void Save(Purchase purchase);

        IEnumerable<Purchase> GetAll();

        IEnumerable<Purchase> GetByDomain(string domain);

        IEnumerable<MemberPurchase> GetByMember(Guid memberId);
    }
}
