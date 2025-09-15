using System.Security.Cryptography;
using Tyuiu.DanilovAS.Sprint1.Task5.V5.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            double x = 32.597;
            DataService ds = new DataService();
            var wait = 5;
            var result = ds.Calculate(x);
            Assert.AreEqual(result, wait);
        }
    }
}
