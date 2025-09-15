using Tyuiu.DanilovAS.Sprint1.Task3.V9.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckConvertMinutesToHours()
        {
            DataService ds = new DataService();
            int min = 150;
            double wait = 2;
            double res = ds.ConvertMinutesToHours(min);
            Assert.AreEqual(res,wait);
        }
    }
}
