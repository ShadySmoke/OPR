using System;

namespace PR3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            double[] array = new double[n];

            Console.WriteLine("Последовательность:");
            while (i < n)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }
            int m = 0, d = 0, j = 0;
            while (m < n/2)
            {
                if (array[j] < 0)
                {
                    d++;
                }
                m++;
                j++;
            }
            Console.WriteLine("Отрицательных чисел в начале последовательности: " + d);
        }
    }
}
