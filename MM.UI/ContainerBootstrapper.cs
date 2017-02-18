using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Dayi.Infrastructure.Data.Seedwork;
using MM.Repository;
using MM.Model.IRepositories;
using MM.Business;

namespace MM.UI
{
    public class ContainerBootstrapper
    {
        private static IUnityContainer _container;
        public IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();
                    Config(_container);
                }
                return _container;
            }
        }

        public IUnityContainer ChildContainer
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();
                    Config(_container);
                }
                return _container.CreateChildContainer();
            }
        }

        private void Config(IUnityContainer container)
        {
            LifetimeManager lifetimeManager = new HierarchicalLifetimeManager();

            container.RegisterType<IQueryableUnitOfWork, MMContext>(lifetimeManager);

            container.RegisterType<ITutorRepository, TutorRepository>();
            container.RegisterType<IPurchaseRepository, PurchaseRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IOneTimeExperienceRepository, OneTimeExperienceRepository>();
            container.RegisterType<IMemberProductRepository, MemberProductRepository>();
            container.RegisterType<ILectureRepository, LectureRepository>();
            container.RegisterType<ITimesCardRepository, TimesCardRepository>();
            container.RegisterType<IMemberRepository, MemberRepository>();
            container.RegisterType<IBalanceRepository, BalanceRepository>();
            container.RegisterType<IConsumptionRepository, ConsumptionRepository>();
            container.RegisterType<IMediumRepository, MediumRepository>();
            container.RegisterType<ISessionRepository, ISessionRepository>();

            container.RegisterType<ITutorMgr, TutorMgr>();
            container.RegisterType<IBalanceMgr, BalanceMgr>();
            container.RegisterType<IConsumptionMgr, ConsumptionMgr>();
            container.RegisterType<IMemberMgr, MemberMgr>();
            container.RegisterType<IProductMgr, ProductMgr>();
            container.RegisterType<IPurchaseMgr, PurchaseMgr>();

            container.RegisterType<IAuthenticator, StudioService>();
            container.RegisterType<IStudioService, StudioService>();
            container.RegisterType<IAdministrator, Administrator>();
        }
    }
}
