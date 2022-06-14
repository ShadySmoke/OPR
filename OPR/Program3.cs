using System;
namespace OPR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(101);
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            int[] newArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArray[i] = array[i];
            }
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                while (array[i] == newArray[j])
                {
                    int k = random.Next(n);
                    int a = array[i];
                    array[i] = array[k];
                    array[k] = a;
                }
                j++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}

