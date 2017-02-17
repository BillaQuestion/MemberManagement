using MM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public interface IConsumptionMgr
    {
        /// <summary>
        /// 保存消费记录
        /// </summary>
        void Save(Consumption consumption);
    }
}
