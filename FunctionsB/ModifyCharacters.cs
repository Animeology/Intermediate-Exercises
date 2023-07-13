namespace IntermediateExercises.FunctionsB
{
    public class ModifyCharacters
    {
        public static void ModifyCharacter()
        {
            Console.WriteLine("Input a text, position of the lettter you want to change and input a new character");

            string text = Console.ReadLine()!;
            int position = Convert.ToInt32(Console.ReadLine());
            char letter = Convert.ToChar(Console.Read());

            Console.WriteLine(ChangeLetter(text, position, letter));

            string ChangeLetter(string text, int position, char letter)
            {
                text = text.Remove(position, 1);
                text = text.Insert(position, letter.ToString());

                return text;
            }
        }
    }
}
