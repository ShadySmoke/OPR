using System;

namespace PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            x = x * (Math.PI / 180);
            double S = Math.Pow(((a - b) / 2), 2)*Math.Tan(x) + b * Math.Tan(x) * Math.Abs((a - b) / 2);    
            
            Console.WriteLine(S);
        }
    }
}
