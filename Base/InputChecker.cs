using System.Text.RegularExpressions;

namespace IntermediateExercises.Base
{
    public class InputChecker
    {
        public static int InputInt()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw new Exception("Invalid input. Not a integer.", ex);
            }
        }

        public static float InputFloat() 
        {
            try
            {
                return Convert.ToSingle(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw new Exception("Invalid input. Not a float.", ex);
            }
        }

        public static double InputDouble()
        {
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw new Exception("Invalid input. Not a double.", ex);
            }
        }

        public static char InputChar()
        {
            try
            {
                return Convert.ToChar(Console.Read()!);
            }
            catch (FormatException ex)
            {
                throw new Exception("Invalid input. Not a char.", ex);
            }
        }

        public static string InputStringOnlyLetters()
        {
            string userInput = Console.ReadLine()!;

            if (Regex.IsMatch(userInput, @"\d"))
            {
                Console.WriteLine("Invalid input. Only letters and not numbers");
                throw new Exception("Invalid input. Not a letter only input");
            }
            return userInput;
        }

        public static string InputStringOnlyNumbers()
        {
            string userInput = Console.ReadLine()!;

            if(Regex.IsMatch(userInput, @"^\d+$"))
            {
                Console.WriteLine("Invalid input. Only numbers and not letters");
                throw new Exception("Invalid input. Not a number only input");
            }
            return userInput;
        }
    }
}
