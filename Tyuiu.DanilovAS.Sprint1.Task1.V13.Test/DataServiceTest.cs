using Tyuiu.DanilovAS.Sprint1.Task1.V13.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double wait = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
