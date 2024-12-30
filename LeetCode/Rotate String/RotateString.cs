using System;

namespace DefaultNamespace
{
    public class RotateString
    {
        static void Main()
        {
            string goal = "abcdefg";

            // Take input from user
            Console.WriteLine("Enter your input:");
            Console.Write("Input: ");
            string input = Console.ReadLine();

            bool isRotation = IsRotation(input, goal);
            Console.WriteLine(isRotation);
        }

        public static bool IsRotation(string input, string goal)
        {
            // Check length first
            if (input.Length != goal.Length)
            {
                return false;
            }

            // Concatenate input with itself and check if goal is a substring
            string doubledInput = string.Concat(input, input);
            return doubledInput.Contains(goal);
        }
    }
}