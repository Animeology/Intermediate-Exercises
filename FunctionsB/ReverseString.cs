namespace IntermediateExercises.FunctionsB
{
    public class ReverseString
    {
        public static void StringReverse()
        {
            Console.WriteLine("Input a text and it will be reverse");

            string text = Console.ReadLine()!;

            InvertString(text);

            void InvertString(string text)
            {
                char[] arr = text.ToCharArray();
                Array.Reverse(arr);
                Console.WriteLine(arr);
            }
        }
    }
}
