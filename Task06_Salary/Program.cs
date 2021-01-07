using System;

namespace Task06_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string nexOpenTab = Console.ReadLine();
                if (nexOpenTab == "Facebook")
                {
                    salary -= 150;
                }
                else if (nexOpenTab == "Instagram")
                {
                    salary -= 100;
                }
                else if (nexOpenTab == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    i = n + 1;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
