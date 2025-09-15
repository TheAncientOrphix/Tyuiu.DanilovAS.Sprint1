using Tyuiu.DanilovAS.Sprint1.Task7.V20.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            var x = 2;
            var y = 4;
            var wait = 9.005;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
