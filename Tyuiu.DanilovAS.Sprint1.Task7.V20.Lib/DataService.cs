using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DanilovAS.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            double z = (2 + Math.Cos(x + y) * Math.Cos(x + y)) / (1 + Math.Abs(x - (3 * x) / (1 + x * x * y * y))) + x * y;
            return Math.Round(z,3);
        }
    }
}
