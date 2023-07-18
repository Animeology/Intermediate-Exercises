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

        public static string InputStringOnlyWords()
        {
            string userInput = Console.ReadLine()!;

            if (Regex.IsMatch(userInput, @"\d"))
            {
                Console.WriteLine("Invalid input. Only words and not numbers");
                throw new Exception("Invalid input. Not an string input");
            }
            return userInput;
        }
    }
}
