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
    }
}
