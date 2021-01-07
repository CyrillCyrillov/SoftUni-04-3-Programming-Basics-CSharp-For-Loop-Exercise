using System;
using System.ComponentModel.DataAnnotations;

namespace Task03_Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double nextNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += nextNumber;
                    if (nextNumber >= evenMax)
                    {
                        evenMax = nextNumber;
                    }
                    if (nextNumber <= evenMin)
                    {
                        evenMin = nextNumber;
                    }
                }
                if (i % 2 != 0)
                {
                    oddSum += nextNumber;
                    if (nextNumber >= oddMax)
                    {
                        oddMax = nextNumber;
                    }
                    if (nextNumber <= oddMin)
                    {
                        oddMin = nextNumber;
                    }
                }
            }
                Console.WriteLine($"OddSum={(oddSum):F2},");
                if (oddMin == double.MaxValue)
                {
                    Console.WriteLine($"OddMin=No,");
                }
                else
                {
                    Console.WriteLine($"OddMin={(oddMin):F2},");
                }
;               if (oddMax == double.MinValue)
                {
                    Console.WriteLine($"OddMax=No,");
                }
                else
                {
                    Console.WriteLine($"OddMax={(oddMax):F2},");
                }                
                Console.WriteLine($"EvenSum={(evenSum):F2},");
                if (evenMin == double.MaxValue)
                {
                    Console.WriteLine($"EvenMin=No,");
                }
                else
                {
                    Console.WriteLine($"EvenMin={(evenMin):F2},");
                }
                if (evenMax == double.MinValue)
                {
                    Console.WriteLine($"EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenMax={(evenMax):F2}");
                }
        }
    }
}
