using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM.Model;
using MM.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Repository.Tests
{
    [TestClass()]
    public class ProductRepositoryTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new DropCreateMMDbWithSeedDataForRepositoryTest());
        }

        [TestCleanup]
        public void Cleanup()
        {
            //var context = new MMContext();
            //context.Database.Delete();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            var productRepository = new ProductRepository(new MMContext());
            var products = productRepository.GetAll().ToList();
            Assert.AreEqual(11, products.Count);
        }

        [TestMethod()]
        public void ModifyOneTimeExperienceTest()
        {
            string productId = "00000000-0000-0001-0003-000000000003";
            var productRepository = new ProductRepository(new MMContext());
            var product = productRepository.GetByKey(Guid.Parse(productId));
            product.Price = 40;
            productRepository.Modify(product);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(Guid.Parse(productId));
            Assert.AreEqual(40, product1.Price);
        }

        [TestMethod()]
        public void ModifyTimesCardTest()
        {
            string productId = "00000000-0000-0001-0002-000000000005";
            Guid mediumId = Guid.Parse("00000000-0000-0000-0001-000000000002");
            var productRepository = new ProductRepository(new MMContext());
            var product = productRepository.GetByKey(Guid.Parse(productId));
            (product as TimesCard).MediumId = mediumId;
            productRepository.Modify(product);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(Guid.Parse(productId));
            Assert.AreEqual(mediumId, (product1 as TimesCard).MediumId);
        }

        [TestMethod()]
        public void ModifyTimesCardChangeMediumTest()
        {
            string productId = "00000000-0000-0001-0002-000000000006";
            Guid mediumId = Guid.Parse("00000000-0000-0000-0001-000000000002");
            var context = new MMContext();
            var productRepository = new ProductRepository(context);
            var product = productRepository.GetByKey(Guid.Parse(productId));

            var mediumRepository = new MediumRepository(context);
            var medium画纸 = mediumRepository.GetByKey(mediumId);
            (product as TimesCard).Medium = medium画纸;
            productRepository.Modify(product);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(Guid.Parse(productId));
            Assert.AreEqual(mediumId, (product1 as TimesCard).MediumId);
        }

        [TestMethod()]
        public void ModifyLectureTest()
        {
            string productId = "00000000-0000-0001-0001-000000000002";
            string description = "课程说明";
            var productRepository = new ProductRepository(new MMContext());
            var product = productRepository.GetByKey(Guid.Parse(productId));
            (product as Lecture).Description = description;
            productRepository.Modify(product);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(Guid.Parse(productId));
            Assert.AreEqual(description, (product1 as Lecture).Description);
        }

        [TestMethod()]
        public void AddOneTimeExperienceTest()
        {
            Guid productId = Guid.Parse("00000000-0000-0001-0003-000000000004");
            Guid mediumId = Guid.Parse("00000000-0000-0000-0001-000000000002");
            var context = new MMContext();
            var productRepository = new ProductRepository(context);
            var mediumRepository = new MediumRepository(context);
            var medium画纸 = mediumRepository.GetByKey(mediumId);
            OneTimeExperience product = new OneTimeExperience()
            { Name = "一次性画布Addtest", Price = 30, Medium = medium画纸 };
            productRepository.Add(product);
            product.ChangeCurrentIdentity(productId);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(productId);
            Assert.AreEqual("一次性画布Addtest", product1.Name);
        }

        [TestMethod()]
        public void AddTimesCardChangeMediumTest()
        {
            Guid productId = Guid.Parse("00000000-0000-0001-0002-000000000007");
            Guid mediumId = Guid.Parse("00000000-0000-0000-0001-000000000002");
            var context = new MMContext();
            var productRepository = new ProductRepository(context);
            var mediumRepository = new MediumRepository(context);
            var medium画纸 = mediumRepository.GetByKey(mediumId);
            TimesCard product = new TimesCard()
            {
                Name = "400元画纸test",
                Price = 400,
                Count = 12,
                Medium = medium画纸
            };
            productRepository.Add(product);
            product.ChangeCurrentIdentity(productId);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(productId);
            Assert.AreEqual(mediumId, (product1 as TimesCard).MediumId);
        }

        [TestMethod()]
        public void AddLectureTest()
        {
            Guid productId = Guid.Parse("00000000-0000-0001-0001-000000000003");
            Guid mediumId = Guid.Parse("00000000-0000-0000-0001-000000000002");
            var context = new MMContext();
            var productRepository = new ProductRepository(context);
            var mediumRepository = new MediumRepository(context);
            var medium画纸 = mediumRepository.GetByKey(mediumId);
            Lecture product = new Lecture()
            {
                Name = "水粉画基础test",
                Price = 998,
                Count = 14,
                Medium = medium画纸,
                Description = "从零开始学习水粉画的基本画法aa"
            };
            productRepository.Add(product);
            product.ChangeCurrentIdentity(productId);
            productRepository.UnitOfWork.Commit();

            var productRepository1 = new ProductRepository(new MMContext());
            var product1 = productRepository.GetByKey(productId);
            Assert.AreEqual("从零开始学习水粉画的基本画法aa", (product1 as Lecture).Description);
        }
    }
}