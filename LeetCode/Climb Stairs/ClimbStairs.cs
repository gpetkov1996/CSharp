using System;

namespace DefaultNamespace
{
    public class ClimbStairs
    {
        static void Main()
        {
            int number = 3;
            Console.WriteLine(CalculateWays(number));
        }
        
        public static int CalculateWays(int n)
        {
            if (n <= 1) return 1;
            
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }

            return second;
        }
    }
}