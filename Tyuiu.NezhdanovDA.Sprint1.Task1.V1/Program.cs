using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NezhdanovDA.Sprint1.Task1.V1.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task1.V1
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
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #1                                                                *");
            Console.WriteLine("* Выполнил: Нежданов Дмитрий Алексеевич | СМАРT6-23-1                        *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные ,   *");
            Console.WriteLine("* вычисляет результат по формуле x / 3 / y + 6 * a и печатает его на экране. *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");

            double a, x, y;

            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(a, x, y));
            Console.ReadLine();
        }
    }
}
