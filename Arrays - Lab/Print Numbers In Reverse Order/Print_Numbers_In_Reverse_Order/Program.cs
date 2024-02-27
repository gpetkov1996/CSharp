using System;

namespace Print_Numbers_In_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] numbers = new int[input];

            for (int i = 0; i < input; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = input - 1; j >= 0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
