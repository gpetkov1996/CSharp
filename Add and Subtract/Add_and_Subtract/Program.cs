using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            int inputThree = int.Parse(Console.ReadLine());

            int sum = SumOfOneAndTwo(inputOne, inputTwo);
            int subtract = SubtractFromSum(sum, inputThree);
            
            Console.WriteLine($"{subtract}");
            
        }

        private static int SubtractFromSum(int sum, int inputThree)
        {
            return sum - inputThree;
        }

        private static int SumOfOneAndTwo(int inputOne, int inputTwo)
        {
            return inputOne + inputTwo;
        }
    }
}
