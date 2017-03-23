using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface ISellRecordMgr
    {

        /// <summary>
        /// 保存购买记录对象
        /// </summary>
        void Save(SellRecord purchase);

        IEnumerable<SellRecord> GetAll();

        IEnumerable<SellRecord> GetByDomain(string domain);

        IEnumerable<SellRecord> GetByMember(Guid memberId);
    }
}
