using System;

namespace MathApp
{
    public class MathOperations
    {
        public static int Subtract(int a, int b)
        {
            int diff = 0;
            for (var i = 0; i < 1; i++)
            {
                diff += a;
                Console.WriteLine("Hi");
                diff -= b;
            }

            return diff;
        }

        public static int Add(int a, int b)
        {
            int sum = 0;
            sum += a;
            sum += b;
            return sum;
        }
    }
}