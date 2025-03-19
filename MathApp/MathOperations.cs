using System;

namespace MathApp
{
    public class MathOperations
    {
        public static int Add(int a, int b)
        {
            int sum = 0;
            sum += a;
            sum += b;
            return sum;
        }

        public static int Subtract(int a, int b)
        {
            int diff = 0;
            diff += a;
            diff -= b;
            return diff;
        }
    }
}