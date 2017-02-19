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
        MMContext _context;
        ITutorRepository _tutorR;
        IProductRepository _productR;
        IMemberRepository _memberR;
        IPurchaseRepository _purchaseR;
        IBalanceRepository _balanceR;
        IConsumptionRepository _consumptionR;
        IMediumRepository _mediumR;
        Administrator _admin;
        ITutorMgr _tutorM;
        IProductMgr _productM;
        IMemberMgr _memberM;
        IPurchaseMgr _purchaseM;
        IConsumptionMgr _consumptionM;
        IBalanceMgr _balanceM;


        [TestInitialize]
        public void initialize()
        {
            Database.SetInitializer(new DropCreateMMDbWithSeedDataForBusinessTest());
            _context = new MMContext();
            _tutorR = new TutorRepository(_context);
            _productR = new ProductRepository(_context);
            _memberR = new MemberRepository(_context);
            _purchaseR = new PurchaseRepository(_context);
            _balanceR = new BalanceRepository(_context);
            _consumptionR = new ConsumptionRepository(_context);
            _mediumR = new MediumRepository(_context);
            //_admin = new Administrator(_tutorR, _productR, _memberR, _purchaseR, _balanceR, _consumptionR, _mediumR);

            _tutorM = new TutorMgr(_tutorR);
            _productM = new ProductMgr(_productR);
            _memberM = new MemberMgr(_memberR, _balanceR);
            _purchaseM = new PurchaseMgr(_purchaseR);
            _consumptionM = new ConsumptionMgr(_consumptionR);
            _balanceM = new BalanceMgr(_balanceR);

            _admin = new Administrator(_tutorM, _productM, _memberM, _purchaseM, _consumptionM, _mediumR);
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
            Assert.AreEqual(_context.Products.Count(), 1);
            var result = _context.Products.FirstOrDefault(x => x.Id == ote.Id);
            Assert.AreEqual(_context.Products.FirstOrDefault(x => x.Id == ote.Id) , ote);

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
            Assert.AreEqual(_context.Products.Count(), 2);
            Assert.AreEqual(_context.Products.FirstOrDefault(x => x.Id == lecture.Id), lecture);

            //Add Medium
            var medium = new Medium() { Name = "testMedium" };
            medium.GenerateNewIdentity();
            _admin.AddMedium(medium);
            Assert.AreEqual(_context.Mediums.Count(), 1);
            Assert.AreEqual(_context.Mediums.FirstOrDefault(x => x.Name == medium.Name).Id, medium.Id);

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
            Assert.AreEqual(_context.Products.Count(), 3);
            Assert.AreEqual(_context.Products.FirstOrDefault(x => x.Id == timesCard.Id), timesCard);

            var tutor = new Tutor()
            {
                Address = "testAddress",
                Gender = Model.Enums.Gender.Female,
                IsManager = true,
                Name = "testName",
                PhoneNumber = "12345678"
            };
            //_admin.AddTutor(tutor);
            Assert.AreEqual(_context.Tutors.Count(), 1);
            Assert.AreEqual(_context.Tutors.FirstOrDefault(x => x.Name == tutor.Name).Id, tutor.Id);

            //_admin.Sell(tutor.Id, timesCard.Id, "testMember", "testPhoneNumber");
            Assert.AreEqual(_context.Purchases.Count(), 1);
            var testSell = _context.Purchases.FirstOrDefault(x => x.ProductId  == timesCard.Id);
            Assert.AreEqual(testSell.Product, timesCard);
            Assert.AreNotEqual(testSell.PurchaseDate, null);
            Assert.AreEqual(testSell.Tutor, tutor);
            Assert.AreEqual(_context.Members.Count(), 1);
            var testMember = _context.Members.FirstOrDefault();
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
            var member = new Member()
            {
                Address = "",
                Name = "123",
                PhoneNumber = "123"
                
            };

            member.GenerateNewIdentity();
            var product = new Lecture()
            {
                Name = "123",
                Count = 2,
                Price = 3M,
                Description = "123"                
            };
            product.GenerateNewIdentity();
            _admin.AddProduct(product);

            var ss = new StudioService(_tutorM, _productM, _memberM, _purchaseM, _consumptionM, _balanceM);
            var tutor = _admin.CreateTutor("123", Model.Enums.Gender.Unknown, "123", "123", false);
            ss.Sell(tutor.Id, product.Id, "123", "123");
            var result = _context.Purchases.FirstOrDefault();
            var test = result as MemberPurchase;
            Assert.AreEqual(test.MemberId, member.Id);
        }
    }
}