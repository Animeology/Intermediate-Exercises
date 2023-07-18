namespace IntermediateExercises.OOP
{
    using Base;
    using Structures;

    public class PersonName
    {
        public void PersonNameInArray()
        {
            Printing.PrintLine("Input 3 names and it will store in the array and displays it");

            int count = 3;

            Person[] persons = new Person[count];

            for (int i = 0; i < count; i++)
            {
                string name = InputChecker.InputString();
                persons[i] = new Person(name);
            }

            for (int i = 0; i < count; i++)
            {
                Printing.PrintLine(persons[i].ToString());
            }
        }
    }
}
