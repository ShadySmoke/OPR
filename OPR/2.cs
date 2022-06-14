using System;

namespace PR3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение z:");
            int z = int.Parse(Console.ReadLine());

            if (x < y + z && y < x + z && z < y + x)
                Console.WriteLine("Треугольник существует");

            else
                Console.WriteLine("Треугольник не существует");
        }
    }
}
