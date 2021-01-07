using System;

namespace Task02_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int nextDigit = int.Parse(Console.ReadLine());
                sum = sum + nextDigit;
                if (max <nextDigit)
                {
                    max = nextDigit;
                }
            }
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max - max)}");
            }
        }
    }
}
