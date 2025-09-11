using Tyuiu.DanilovAS.Sprint1.Task0.V9.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            var res = ds.Calculate();
            var wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
