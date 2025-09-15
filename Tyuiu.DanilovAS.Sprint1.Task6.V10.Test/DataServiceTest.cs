using Tyuiu.DanilovAS.Sprint1.Task6.V10.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestDeleteMiddleLetter()
        {
            DataService ds = new DataService();
            var wait = "Привет кк дела";
            var res = ds.DeleteMiddleLetter("Привет как дела");
            Assert.AreEqual(res, wait);
        }
    }
}
