using MM.Business;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM.Repository;
using System.Data.Entity;
using System;
using System.Linq;
using MM.Model;

namespace MM.Business.Tests
{
    [TestClass()]
    public class StudioServiceTests
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MMContext>());
            MMContext dbContext = new MMContext();
            dbContext.Database.Initialize(true);
        }

        [TestInitialize]
        public void TestInit()
        {
            new PrepareDatas().CreateDatas();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            new PrepareDatas().CleanDatas();
        }

        [TestMethod()]
        public void AuthenticateTest_正确()
        {
            string userName = "admin";
            string password = "password";

            var target = new ContainerBootstrapper().ChildContainer.Resolve<IAuthenticator>();
            var actual = target.Authenticate(userName, password);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void AuthenticateTest_用户名不存在()
        {
            string userName = "admin1";
            string password = "password";

            var target = new ContainerBootstrapper().ChildContainer.Resolve<IAuthenticator>();
            var actual = target.Authenticate(userName, password);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void AuthenticateTest_密码不正确()
        {
            string userName = "admin";
            string password = "password1";

            var target = new ContainerBootstrapper().ChildContainer.Resolve<IAuthenticator>();
            var actual = target.Authenticate(userName, password);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void SellTest_会员产品_销售给新会员()
        {
            var target = new ContainerBootstrapper().ChildContainer.Resolve<IStudioService>();

            string tutorName = "admin";
            Guid productId = Guid.Parse("00000000-0000-0001-0002-000000000002");
            string customerName = "张三";
            string phoneNumber = "12345678";

            target.Sell(tutorName, productId, customerName, phoneNumber);

            // 检查 销售记录
            ISellRecordMgr sellRecordMgr = new ContainerBootstrapper().ChildContainer.Resolve<ISellRecordMgr>();
            var sellRecords = sellRecordMgr.GetAll();
            Assert.AreEqual(2, sellRecords.Count());
            var sellRecord = sellRecords.First(s => s.ProductId == productId);
            Assert.IsNotNull(sellRecord);
            if (sellRecord != null)
            {
                Assert.AreEqual(500, sellRecord.Price);
                Assert.AreEqual(DateTime.Today.ToString("yyyy-MM-dd"), sellRecord.SellDate.ToString("yyyy-MM-dd"));
                Assert.AreEqual(Guid.Parse("00000000-0000-0002-0001-000000000001"), sellRecord.TutorId);
            }

            // 检查会员
            IMemberMgr memberMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMemberMgr>();
            var member = memberMgr.GetByPhoneNumber(phoneNumber);
            Assert.IsNotNull(member);
            if (member != null)
            {
                Assert.AreEqual(customerName, member.Name);
                Assert.AreEqual(1, member.MemberCards.Count);

                var memberCard = member.MemberCards.First();
                if (memberCard != null)
                {
                    Assert.IsTrue(memberCard is TimesCardMemberCard);
                }
            }
        }

        [TestMethod()]
        public void SellTest_会员产品_销售给老会员()
        {
            var target = new ContainerBootstrapper().ChildContainer.Resolve<IStudioService>();

            string tutorName = "admin";
            Guid productId = Guid.Parse("00000000-0000-0001-0002-000000000002");
            string customerName = "张三";
            string phoneNumber = "1234567890";

            target.Sell(tutorName, productId, customerName, phoneNumber);

            // 检查 销售记录
            ISellRecordMgr sellRecordMgr = new ContainerBootstrapper().ChildContainer.Resolve<ISellRecordMgr>();
            var sellRecords = sellRecordMgr.GetAll();
            Assert.AreEqual(2, sellRecords.Count());
            var sellRecord = sellRecords.First(s => s.ProductId == productId);
            Assert.IsNotNull(sellRecord);
            if (sellRecord != null)
            {
                Assert.AreEqual(500, sellRecord.Price);
                Assert.AreEqual(DateTime.Today.ToString("yyyy-MM-dd"), sellRecord.SellDate.ToString("yyyy-MM-dd"));
                Assert.AreEqual(Guid.Parse("00000000-0000-0002-0001-000000000001"), sellRecord.TutorId);
            }

            // 检查会员
            IMemberMgr memberMgr = new ContainerBootstrapper().ChildContainer.Resolve<IMemberMgr>();
            var member = memberMgr.GetByPhoneNumber(phoneNumber);
            Assert.IsNotNull(member);
            if (member != null)
            {
                Assert.AreEqual(2, member.MemberCards.Count);

                var memberCard = member.MemberCards.First(o => o.ProductId == productId);
                if (memberCard != null)
                {
                    Assert.AreEqual("画布", memberCard.MediumName, "会员卡介质名称");
                }
            }
        }

        [TestMethod]
        public void SellTest_体验产品()
        {
            var target = new ContainerBootstrapper().ChildContainer.Resolve<IStudioService>();

            string tutorName = "admin";
            Guid productId = Guid.Parse("00000000-0000-0001-0002-000000000003");
            string customerName = "张三";
            string phoneNumber = "12345678";

            target.Sell(tutorName, productId, customerName, phoneNumber);

            ISellRecordMgr sellRecordMgr = new ContainerBootstrapper().ChildContainer.Resolve<ISellRecordMgr>();
            var sellRecords = sellRecordMgr.GetAll().Where(o => o.ProductId == productId);
            Assert.AreEqual(1, sellRecords.Count());
            var sellRecord = sellRecords.First();
            Assert.AreEqual(productId, sellRecord.ProductId);
            Assert.AreEqual(1000, sellRecord.Price);
            Assert.AreEqual(DateTime.Today.ToString("yyyy-MM-dd"), sellRecord.SellDate.ToString("yyyy-MM-dd"));
            Assert.AreEqual(Guid.Parse("00000000-0000-0002-0001-000000000001"), sellRecord.TutorId);
        }
    }
}