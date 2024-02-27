using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //string correctPassword = new string(username.ToCharArray().Reverse().ToArray());
            //int atempts = 0;

            //while (password != correctPassword)
            //{
            //    Console.WriteLine("Incorrect password. Try again.");
            //    atempts++;
            //    password = Console.ReadLine();
            //    if (atempts == 4)
            //    {
            //        Console.WriteLine($"User {username} blocked!");
            //    }
            //}
            //    Console.WriteLine($"User {username} logged in.");

            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                char symbol = userName[i];
                password += symbol;
            }
            for (int i = 0; i < 4; i++)
            {
                string currentPassword = Console.ReadLine();
                if (currentPassword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (password != currentPassword && i >= 0 && i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password != currentPassword && i == 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                }
            }
        }
    }
}
