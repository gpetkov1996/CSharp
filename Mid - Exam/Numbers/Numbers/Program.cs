using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Finish")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "Replace":
                        //int indexToRemoveAt = int.Parse(tokens[1]);
                        //numbers.RemoveAt(indexToRemoveAt);
                        int index = numbers.IndexOf(int.Parse(tokens[1]));
                        if (index != -1)
                            numbers[index] = int.Parse(tokens[2]);
                        break;
                    case "Collapse":
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(tokens[1]))
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}