using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NezhdanovDA.Sprint1.Task0.V16.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task0.V16
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
            Console.WriteLine("* Вариант #16                                                                *");
            Console.WriteLine("* Выполнил: Нежданов Дмитрий Алексеевич | СМАРT6-23-1                        *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 24 / (6 * 2) - 24 / 6 / 4  *");
            Console.WriteLine("* и печатает результат на экране.                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("* 24 / (6 * 2) - 24 / 6 / 4                                                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
