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
    public class MemberRepositoryTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new DropCreateMMDbWithSeedData());
        }

        [TestCleanup]
        public void Cleanup()
        {
            var context = new MMContext();
            context.Database.Delete();
        }

        [TestMethod()]
        public void GetOneTimeExperienceTest()
        {
            var context = new MMContext();
            var productRepository = new ProductRepository(context);
            var products = productRepository.GetAll().ToList();
            Assert.IsTrue(products.First() is OneTimeExperience);
        }
    }
}