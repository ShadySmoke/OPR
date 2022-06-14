using System;

namespace PR3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                if (i % 47 == 43 && i % 43 == 47)
                    Console.WriteLine(i);
            }
        }
    }
}
