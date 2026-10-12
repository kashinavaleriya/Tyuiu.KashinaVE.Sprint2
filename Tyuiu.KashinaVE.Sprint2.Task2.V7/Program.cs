using Tyuiu.KashinaVE.Sprint2.Task2.V7.Lib;

namespace Tyuiu.KashinaVE.Sprint2.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #2 | Выполнила: Кашина В. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Кашина Валерия Евгеньевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*   1 2 3 4 5 6 7 8 9 10 11 12 13 14 15                                   *");
            Console.WriteLine("* 1                                                                       *");
            Console.WriteLine("* 2                                                                       *");
            Console.WriteLine("* 3     * * *       * * * *                                               *");
            Console.WriteLine("* 4     * * *       * * * *                                               *");
            Console.WriteLine("* 5     * * * * * * * * * *                                               *");
            Console.WriteLine("* 6     * * * * * * * * * * *                                             *");
            Console.WriteLine("* 7     * * * * * * * * * * *                                             *");
            Console.WriteLine("* 8       * * * * * * * * * *                                             *");
            Console.WriteLine("* 9       * *       * * *                                                 *");
            Console.WriteLine("* 10      * *       * * *                                                 *");
            Console.WriteLine("* 11    * * *       * * *                                                 *");
            Console.WriteLine("* 12      * * *     *                                                     *");
            Console.WriteLine("* 13      * * *                                                           *");
            Console.WriteLine("* 14                                                                      *");
            Console.WriteLine("* 15                                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("* Точка находится в заштрихованной области                                *");
            }
            else
            {
                Console.WriteLine("* Точка не находится в заштрихованной области                             *");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}


