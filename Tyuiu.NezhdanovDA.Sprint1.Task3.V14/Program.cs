using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NezhdanovDA.Sprint1.Task3.V14.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task3.V14
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
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #0                                                                 *");
            Console.WriteLine("* Выполнил: Нежданов Дмитрий Алексеевич | СМАРT6-23-1                        *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.                *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите трёхзначное число = " );
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number % 10;
            int x = (number / 10) % 10;
            int y = number / 100;
            int ReverseNumber = a * 100 + x * 10 + y;
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("Число в обратном порядке :{0:0.000} ", ReverseNumber);
            Console.ReadLine();
        }
    }
}
