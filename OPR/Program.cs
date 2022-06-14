using System;
namespace OPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число попыток:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимум промежутка:");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int r = random.Next(1, n);
            int j = 0;
            for (int i = 0; i < k; i++)
            {
                Console.Write("Введите ваше число:\t");
                int number = int.Parse(Console.ReadLine());

                if (number == r)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы угадали");
                    j++;
                    break;
                }
                else if (number < r)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }
            if (j == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Попытки закончились");
            }
        }
    }
}
