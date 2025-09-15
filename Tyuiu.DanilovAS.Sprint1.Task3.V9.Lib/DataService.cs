using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DanilovAS.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
            double result = minutes / 60;
            return result;
        }
    }
}
