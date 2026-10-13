using Tyuiu.KashinaVE.Sprint2.Task6.V10.Lib;

namespace Tyuiu.KashinaVe.Sprint2.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string res;

            Console.Title = "Спринт #2 | Выполнила: Кашина В. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Кашина Валерия Евгеньевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
            Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня.                   *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)) || ((g < 1)))
            {
                res = "Введены не верные значени";

            }
            else
            {
                res = "Предыдущая дата:" + ds.FindDateOfPreviousDay(g, m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
