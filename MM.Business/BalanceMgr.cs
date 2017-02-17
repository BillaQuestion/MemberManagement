using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model;
using MM.Model.IRepositories;
using Dayi.Data.Domain.Seedwork.Specification;

namespace MM.Business
{
    public class BalanceMgr : IBalanceMgr
    {
        IBalanceRepository _balanceRepository;

        public BalanceMgr(IBalanceRepository balanceRepository)
        {
            _balanceRepository = balanceRepository;
        }

        void IBalanceMgr.Save(Balance balance)
        {
            if (balance.Remainder == 0)
            {
                _balanceRepository.Remove(balance);
            }
            else
            {
                if (balance.IsTransient())
                {
                    balance.GenerateNewIdentity();
                    _balanceRepository.Add(balance);
                }
                else
                    _balanceRepository.Modify(balance);
            }
            _balanceRepository.UnitOfWork.Commit();
        }
    }
}