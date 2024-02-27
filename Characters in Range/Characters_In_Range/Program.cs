using System;

namespace Characters_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            int iOne = (int)Convert.ToChar(inputOne);
            int iTwo = (int)Convert.ToChar(inputTwo);

            CharsInRange(iOne, iTwo);

        }

        private static void CharsInRange(int iOne, int iTwo)
        {
            if (iOne < iTwo)
            {
                for (int i = iOne + 1; i < iTwo; i++)
                {
                    char c = Convert.ToChar(i);
                    Console.Write($"{c} ");
                }
            }
            else if (iTwo < iOne)
            {
                for (int i = iTwo + 1; i < iOne; i++)
                {
                    char c = Convert.ToChar(i);
                    Console.Write($"{c} ");
                }
            }
        }
    }
}
