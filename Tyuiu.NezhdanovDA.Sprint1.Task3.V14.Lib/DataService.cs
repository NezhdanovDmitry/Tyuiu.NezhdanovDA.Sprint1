using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NezhdanovDA.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            double a = (int)(number % 10);
            double x = (int)(number / 10) % 10;
            double y = (int)number / 100;
            double ReverseNumber = a * 100 + x * 10 + y;
            return Math.Round(ReverseNumber, 3);
        }


    }
}
