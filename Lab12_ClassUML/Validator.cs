using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Validator
    {
        public static double TryParseDouble(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            try
            {
                double userInput = double.Parse(input);
                return userInput;

            }
            catch (FormatException)
            {
                return TryParseDouble("That was not a number. Please enter a correct number: ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}");
                return TryParseDouble("Please enter a correct number: ");
            }
        }
        public static int TryParseInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            try
            {
                int userInput = int.Parse(input);
                return userInput;

            }
            catch (FormatException)
            {
                return TryParseInt("That was not a number. Please enter a correct number: ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}");
                return TryParseInt("Please enter a correct number: ");
            }
        }
    }
}
