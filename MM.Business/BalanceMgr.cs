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

        void IBalanceMgr.Create(MemberProduct memberProduct, int remainder)
        {
            var balance = new Balance()
            {
                Product = memberProduct,
                MemberProductId = memberProduct.Id,
                Remainder = remainder
            };
            if (balance.IsTransient())
                balance.GenerateNewIdentity();
            _balanceRepository.Add(balance);
            _balanceRepository.UnitOfWork.Commit();
        }

        IEnumerable<Balance> IBalanceMgr.Gets(Guid productId)
        {
            ISpecification<Balance> spec = new DirectSpecification<Balance>(b => b.MemberProductId == productId);
            return _balanceRepository.FindBySpecification(spec);
        }

        IEnumerable<Balance> IBalanceMgr.GetAll()
        {
            return _balanceRepository.GetAll();
        }

        void IBalanceMgr.Modify(Balance balance)
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