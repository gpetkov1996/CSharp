using System;
using System.Linq;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                //:|:
                string[] cmdTokens = command.Split(":|:");
                //Change All
                switch (cmdTokens[0])
                {
                    case "ChangeAll":
                        {
                            string substring = cmdTokens[1];
                            //Take the replacement
                            string replacement = cmdTokens[2];
                            message = message.Replace(substring, replacement);
                            break;
                        }
                    case "Reverse":
                        {
                            string substring = cmdTokens[1];
                            if (message.Contains(substring))
                            {
                                int index = message.IndexOf(substring);
                                message = message.Remove(index, substring.Length);
                                message = $"{message}{string.Join("",substring.Reverse())}";
                            }
                            else
                            {
                                Console.WriteLine("error");
                                command = Console.ReadLine();
                                continue;
                            }
                            break;
                        }
                    case "InsertSpace":
                        {
                            int index = int.Parse(cmdTokens[1]);
                            message = message.Insert(index, " ");
                            break;
                        }
                }

                Console.WriteLine(message);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ypu have a new text message: {message}");
        }
    }
}
