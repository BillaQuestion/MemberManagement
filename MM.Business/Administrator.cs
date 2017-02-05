using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Model;
using MM.Model.IRepositories;

namespace MM.Business
{
    public class Administrator : TutorMgr
    {
        ITutorRepository _tutorRepository;
        IProductRepository _productRepository;
        IMemberRepository _memberRepository;
        IPurchaseRepository _purchaseRepository;
        IBalanceRepository _balanceRepository;

        public Administrator(ITutorRepository tutorRepository, IProductRepository productRepository, IMemberRepository memberRepository, IPurchaseRepository purchaseRepository, IBalanceRepository balanceRepository) : base(tutorRepository, productRepository, memberRepository, purchaseRepository, balanceRepository) { }

        public void SetMember()
        {

        }

        public void AddProduct()
        {

        }

        public void SetProduct()
        {

        }

        public void RemoveProduct()
        {

        }

        public void AddTutor()
        {

        }

        public void SetTutor()
        {

        }

        public void RemoveTutor()
        {

        }

    }
}