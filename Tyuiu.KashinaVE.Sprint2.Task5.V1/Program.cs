using Tyuiu.KashinaVE.Sprint2.Task5.V1.Lib;

namespace Tyuiu.KashinaVe.Sprint2.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Кашина В. Е. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся струр                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Кашина Валерия Евгеньевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* значение и возвращает результат. Условие: По данному номеру месяца,     *");
            Console.WriteLine("* количество дней в этом месяце.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
           
            Console.WriteLine("Введите номер месяца: ");
            int numMouth = Convert.ToInt32(Console.ReadLine());


            string res;

            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "В " + numMouth + " месяце " + ds.FindMonthDaysCount(numMouth) + " дней";
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
