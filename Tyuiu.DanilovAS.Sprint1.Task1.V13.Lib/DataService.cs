using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DanilovAS.Sprint1.Task1.V13.Lib
{
    public class DataService : ISprint1Task1V13
    {
        public double Calculate(double x)
        {
            double res = x / (0.5 * x);
            return res;
        }
    }
}
