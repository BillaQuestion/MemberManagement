using Dayi.Infrastructure.Data.Seedwork;
using Microsoft.Practices.Unity;
using MM.Model.IRepositories;
using MM.Repository;

namespace MM.Business.Tests
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
            container.RegisterType<ISellRecordRepository, SellRecordRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IOneTimeExperienceRepository, OneTimeExperienceRepository>();
            container.RegisterType<IMemberProductRepository, MemberProductRepository>();
            container.RegisterType<ILectureRepository, LectureRepository>();
            container.RegisterType<ITimesCardRepository, TimesCardRepository>();
            container.RegisterType<IMemberRepository, MemberRepository>();
            container.RegisterType<IMemberCardRepository, MemberCardRepository>();
            container.RegisterType<IConsumptionRepository, ConsumptionRepository>();
            container.RegisterType<IMediumRepository, MediumRepository>();
            container.RegisterType<ISessionRepository, ISessionRepository>();

            container.RegisterType<ITutorMgr, TutorMgr>();
            container.RegisterType<IMemberCardMgr, MemberCardMgr>();
            container.RegisterType<IConsumptionMgr, ConsumptionMgr>();
            container.RegisterType<IMemberMgr, MemberMgr>();
            container.RegisterType<IProductMgr, ProductMgr>();
            container.RegisterType<ISellRecordMgr, SellRecordMgr>();
            container.RegisterType<IMediumMgr, MediumMgr>();

            container.RegisterType<IAuthenticator, StudioService>();
            container.RegisterType<IStudioService, StudioService>();
        }
    }
}
