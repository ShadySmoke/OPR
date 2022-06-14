using System;

namespace PR3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            int b = int.Parse(Console.ReadLine());

            int k = 1;

            Console.WriteLine("Кубы чисел:");
            for (int i = a; i < b; i++)
            {
                k = i * i * i;
                Console.WriteLine(k);
            }
        }
    }
}
