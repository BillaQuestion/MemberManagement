using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public class ConsumptionMgr: IConsumptionMgr
    {
        IConsumptionRepository _consumptionRepository;
        public ConsumptionMgr(IConsumptionRepository consumptionRepository)
        {
            _consumptionRepository = consumptionRepository;
        }

        /// <summary>
        /// 保存消费记录
        /// </summary>
        public void Save(Consumption consumption)
        {
            if (consumption.IsTransient())
            {
                consumption.GenerateNewIdentity();
                _consumptionRepository.Add(consumption);
            }
            else
                _consumptionRepository.Modify(consumption);

            _consumptionRepository.UnitOfWork.Commit();
        }
    }
}
