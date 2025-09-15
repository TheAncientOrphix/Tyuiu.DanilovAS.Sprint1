using Tyuiu.DanilovAS.Sprint1.Task2.V18.Lib;
namespace Tyuiu.DanilovAS.Sprint1.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значание длины параллелепипеда (целое число) => ");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значание ширины параллелепипеда (целое число) => ");
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значание высоты параллелепипеда (целое число) => ");
            int valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.CalculateSideSquareParallelepiped(valueOne, valueTwo, valueThree);
            Console.WriteLine($"Площадь боковой поверхности параллелепипеда равна => ");
            Console.ReadKey();
        }
    }
}
