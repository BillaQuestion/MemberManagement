using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Repository;
using MM.Model;

namespace MM.Business.Tests
{
    [TestClass()]
    public class AdministratorTests
    {
        [TestInitialize]
        public void initialize()
        {
            Database.SetInitializer(new DropCreateMMDbWithSeedDataForBusinessTest());
        }

        [TestCleanup]
        public void Cleanup()
        {
            var context = new MMContext();
            context.Database.Delete();
        }

        [TestMethod()]
        public void OverAllFuntionTest()
        {
            var context = new MMContext();
            var tutorR = new TutorRepository(context);
            var productR = new ProductRepository(context);
            var memberR = new MemberRepository(context);
            var purchaseR = new PurchaseRepository(context);
            var balanceR = new BalanceRepository(context);
            var consumptionR = new ConsumptionRepository(context);
            var mediumR = new MediumRepository(context);
            var admin = new Administrator(tutorR, productR, memberR, purchaseR, balanceR, consumptionR, mediumR);

            //Add OneTimeExperience : Product
            var ote = new OneTimeExperience()
            {
                Name = "testOTE",
                Price = 10.3M
            };
            var result = productR.GetAll();
            Assert.AreEqual(result.Count(), 1);
            Assert.AreEqual(result.Last(), ote);
            
        }
    }
}