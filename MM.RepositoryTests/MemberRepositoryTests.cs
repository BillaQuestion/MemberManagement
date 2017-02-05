using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Repository.Tests
{
    [TestClass()]
    public class MemberRepositoryTests
    {
        [TestMethod()]
        public void CreateMMDb()
        {
            var context = new MMContext();
            var productRepository = new ProductRepository(context);
            var products = productRepository.GetAll().ToList();
        }
    }
}