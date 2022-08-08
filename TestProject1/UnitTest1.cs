using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Services;
using WebApplication1.Models;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepo<int, Customer> repo = new CustomerRepo();
            var result = repo.GetAll();
            result.Wait();
            int count = result.Result.Count;
            Assert.AreEqual(1, count);
        }
    }
}
