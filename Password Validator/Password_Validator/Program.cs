using System;
using System.Linq;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
       
            PasswordCheck(password);
        }

        private static void PasswordCheck(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                int x = password.Count(c => Char.IsDigit(c));
                bool symbolCheck = password.Any(p => !char.IsLetterOrDigit(p));
                if (symbolCheck == true && x < 2)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    Console.WriteLine($"Password must have at least 2 digits");
                }
                else if (x < 2)
                {
                    Console.WriteLine($"Password must have at least 2 digits");
                }
                else if (symbolCheck == true)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                else
                {
                    Console.WriteLine("Password is valid");
                }
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                int x = password.Count(c => Char.IsDigit(c));
                bool symbolCheck = password.Any(p => !char.IsLetterOrDigit(p));
                if (symbolCheck == true && x < 2)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    Console.WriteLine($"Password must have at least 2 digits");
                }
                else if (x < 2)
                {
                    Console.WriteLine($"Password must have at least 2 digits");
                }
                else if (symbolCheck == true)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                else
                {
                    Console.WriteLine("Password is valid");
                }
            }
        }
    }
}
