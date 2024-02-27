using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] numbers = input
          .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
          .Select(val => double.Parse(val))
          .ToArray();

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero)}");

            }
        }
    }
}
