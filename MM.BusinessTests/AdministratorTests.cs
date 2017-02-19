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
using MM.Model.IRepositories;

namespace MM.Business.Tests
{
    [TestClass()]
    public class AdministratorTests
    {
        MMContext context;
         tutorR;
         productR;
         memberR;
        IPurchaseRepository purchaseR;
        IBalanceRepository balanceR;
        IConsumptionRepository consumptionR;
        IMediumRepository mediumR;
        IAdministrator _admin;


        [TestInitialize]
        public void initialize()
        {
            Database.SetInitializer(new DropCreateMMDbWithSeedDataForBusinessTest());
            MMContext context = new MMContext();
            ITutorRepository tutorR = new TutorRepository(context);
            IProductRepository productR = new ProductRepository(context);
            IMemberRepository memberR = new MemberRepository(context);
            purchaseR = new PurchaseRepository(context);
            balanceR = new BalanceRepository(context);
            consumptionR = new ConsumptionRepository(context);
            mediumR = new MediumRepository(context);
            //_admin = new Administrator(_tutorR, _productR, _memberR, _purchaseR, _balanceR, _consumptionR, _mediumR);
        }

        [TestCleanup]
        public void Cleanup()
        {
            var context = new MMContext();
            context.Database.Delete();
        }
        
        [TestMethod()]
        public void OverAllAdminFuntionTest()
        {
            //Add OneTimeExperience : Product
            var ote = new OneTimeExperience()
            {
                Name = "testOTE",
                Price = 10.3M
            };
            ote.GenerateNewIdentity();
            _admin.AddProduct(ote);
            Assert.AreEqual(context.Products.Count(), 1);
            var result = context.Products.FirstOrDefault(x => x.Id == ote.Id);
            Assert.AreEqual(context.Products.FirstOrDefault(x => x.Id == ote.Id) , ote);

            //Add Lecture : MemberProduct : Product
            var lecture = new Lecture()
            {
                Count = 10,
                Description = "test description",
                Name = "testLecture",
                Price = 10.4M
            };
            lecture.GenerateNewIdentity();
            _admin.AddProduct(lecture);
            Assert.AreEqual(context.Products.Count(), 2);
            Assert.AreEqual(context.Products.FirstOrDefault(x => x.Id == lecture.Id), lecture);

            //Add Medium
            var medium = new Medium() { Name = "testMedium" };
            medium.GenerateNewIdentity();
            _admin.AddMedium(medium);
            Assert.AreEqual(context.Mediums.Count(), 1);
            Assert.AreEqual(context.Mediums.FirstOrDefault(x => x.Name == medium.Name).Id, medium.Id);

            //Add TimesCard : MemberProduct : Product
            var timesCard = new TimesCard()
            {
                Count = 10,
                Medium = medium,
                Name = "testTimesCard",
                Price = 9.9M
            };
            timesCard.GenerateNewIdentity();
            _admin.AddProduct(timesCard);
            Assert.AreEqual(context.Products.Count(), 3);
            Assert.AreEqual(context.Products.FirstOrDefault(x => x.Id == timesCard.Id), timesCard);

            var tutor = new Tutor()
            {
                Address = "testAddress",
                Gender = Model.Enums.Gender.Female,
                IsManager = true,
                Name = "testName",
                PhoneNumber = "12345678"
            };
            _admin.AddTutor(tutor);
            Assert.AreEqual(context.Tutors.Count(), 1);
            Assert.AreEqual(context.Tutors.FirstOrDefault(x => x.Name == tutor.Name).Id, tutor.Id);

            //_admin.Sell(tutor.Id, timesCard.Id, "testMember", "testPhoneNumber");
            Assert.AreEqual(context.Purchases.Count(), 1);
            var testSell = context.Purchases.FirstOrDefault(x => x.ProductId  == timesCard.Id);
            Assert.AreEqual(testSell.Product, timesCard);
            Assert.AreNotEqual(testSell.PurchaseDate, null);
            Assert.AreEqual(testSell.Tutor, tutor);
            Assert.AreEqual(context.Members.Count(), 1);
            var testMember = context.Members.FirstOrDefault();
            Assert.AreEqual(testMember.Name, "testMember");
            Assert.AreEqual(testMember.PhoneNumber, "testPhoneNumber");
            Assert.AreEqual(testMember.Address, null);
            Assert.AreEqual(testMember.Balances.Count, 1);
            Assert.AreEqual(testMember.Balances.FirstOrDefault().Product, timesCard);
            Assert.AreEqual(testMember.Gender, Model.Enums.Gender.Male);

            //var newMember = new Member()
            //{
            //    Address = "testAddress",
            //    PhoneNumber = "testPhoneNunber",
            //    Name ="testMember"
            //};
            //_admin.ModifyMember(newMember);
            //Assert.AreEqual(_context.Members.Count(), 1);
            //Assert.AreEqual(_context.Members.FirstOrDefault().Id, testMember.Id);
            //Assert.AreEqual(_context.Members.FirstOrDefault().Address, "testAddress");
        }

        [TestMethod]
        public void Demo()
        {
            IBalanceMgr balanceMgr = new BalanceMgr(balanceR);

            MemberProduct p1 = new Lecture()
            {
                Count = 2,
                Description = "dd",
                Name = "dd",
                Price = 10M
            };
            p1.GenerateNewIdentity();

            MemberProduct p2 = new Lecture()
            {
                Count = 9,
                Description = "ee",
                Name = "ee",
                Price = 10M
            };
            p2.GenerateNewIdentity();

        }
    }
}