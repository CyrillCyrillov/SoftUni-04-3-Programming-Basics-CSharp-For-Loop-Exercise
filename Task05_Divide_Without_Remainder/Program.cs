using System;

namespace Task05_Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());
                if (nextNumber % 2 == 0)
                {
                    p1 += 1;
                }
                if (nextNumber % 3 == 0)
                {
                    p2 += 1;
                }
                if (nextNumber % 4 == 0)
                {
                    p3 += 1;
                }
            }
            Console.WriteLine($"{(p1 / n * 100):F2}%");
            Console.WriteLine($"{(p2 / n * 100):F2}%");
            Console.WriteLine($"{(p3 / n * 100):F2}%");
        }
    }
}
