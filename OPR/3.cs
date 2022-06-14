using System;

namespace PR3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int s = 0, p = 1;

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                s += array[i];
                p *= array[i];
            }

            Console.WriteLine("Сумма:\t" + s);
            Console.WriteLine("Произведение:\t" + p);
        }
    }
}
