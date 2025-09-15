using Tyuiu.DanilovAS.Sprint1.Task4.V13.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране. Ответ          *");
            Console.WriteLine("* округлите до 3 знаков после запятой.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X => ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y => ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(x, y);
            Console.WriteLine("Cos(Pi/x)/(3*e^(x+y)) = " + Convert.ToDouble(res));
            Console.ReadKey();
        }
    }
}
