using Tyuiu.DanilovAS.Sprint1.Task4.V13.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            var x = 1;
            var y = 2;
            var wait = -0.017;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(result, wait);
        }
    }
}
