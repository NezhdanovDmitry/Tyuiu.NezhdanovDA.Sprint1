using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NezhdanovDA.Sprint1.Task2.V1.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task2.V1
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
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #1                                                                *");
            Console.WriteLine("* Выполнил: Нежданов Дмитрий Алексеевич | СМАРT6-23-1                        *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.                *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            

            Console.WriteLine("Введите расстояние в километрах: ");
            int Km = Convert.ToInt32(Console.ReadLine());

            double M = Km / 1.609;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Расстояние в милях = {0:0.000} ", M );

            Console.ReadLine();
        }
    }
}
