using System.CodeDom.Compiler;
using Tyuiu.DanilovAS.Sprint1.Task2.V18.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculateSideSquareParallelepiped()
        {
            DataService ds = new DataService();
            int valueOne = 4;
            int valueTwo = 8;
            int valueThree = 6;
            var res = ds.CalculateSideSquareParallelepiped(valueOne, valueTwo, valueThree);
            int wait = 144;
            Assert.AreEqual(res, wait);
        }
    }
}
