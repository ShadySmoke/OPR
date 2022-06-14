using System;
namespace OPR_5
{
    class Program
    {
        static int Random(int a, int b)
        {
            Random rand = new Random();
            int k = rand.Next(a, b);
            return k;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                int r = Random(a, b + 1);
                Console.Write(r);
                Console.Write(" ");
                System.Threading.Thread.Sleep(2);
            }
            Console.WriteLine();
        }        
    }
}
