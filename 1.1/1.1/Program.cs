//Посчитать факториал

using System;

namespace _1._1
{
    class Program
    {
        private static int FactorialCalculation(int factorial)
        {
            int answer = 1;
            int maxValue = int.MaxValue;
            for (int helper = 1; helper <= factorial; helper++)
            {
                if (maxValue/helper < answer)
                {
                    return 0;
                }
                answer *= helper;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate factorial");
            int factorial = Convert.ToInt32(Console.ReadLine());
            int answer = FactorialCalculation(factorial);
            if (answer > 0)
            {
                Console.WriteLine("The factorial of " + factorial + " is " + FactorialCalculation(factorial));
            }
            else
            {
                Console.WriteLine("Over the limit number");
            }
        }
    }
}
