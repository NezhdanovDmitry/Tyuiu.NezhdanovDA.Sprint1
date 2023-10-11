using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NezhdanovDA.Sprint1.Task4.V9.Lib;

namespace Tyuiu.NezhdanovDA.Sprint1.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Cпринт #1 | Выполнил: Нежданов Д. А. | СМАРT6-23-1";


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Cпринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #0                                                                 *");
            Console.WriteLine("* Выполнил: Нежданов Дмитрий Алексеевич | СМАРT6-23-1                        *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* вычисляет результат по формуле и печатает на экране                        *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("* ФОРМУЛА:                                                                   *");
            Console.WriteLine("*           ln(x, y)                                                         *");
            Console.WriteLine("*     --------------------------                                             *");
            Console.WriteLine("*   (x - sqrt((x) - (1 + x ^ 2)))                                            *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("ln(xy) / (x - sqrt((x) - (1 + x ^ 2))) = {0:0.000}", ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
