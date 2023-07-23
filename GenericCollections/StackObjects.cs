namespace IntermediateExercises.GenericCollections
{
    using Base;
    using Structures;

    public class StackObjects
    {
        Stack<Person> objects = new Stack<Person>();

        const int STACK_COUNT = 3;

        void CreatePersonInStack()
        {
            Printing.PrintLine("Create three Person with their name and age and it will print the three Person");

            for (int i = 0; i < STACK_COUNT; i++)
            {
                string name = InputChecker.InputStringOnlyLetters();
                int age = InputChecker.InputInt();

                objects.Push(new Person()
                {
                    m_name = name,
                    m_age = age
                });
            }
        }

        public void PrintPersonInQueue()
        {
            CreatePersonInStack();

            foreach (Person p in objects)
            {
                Printing.PrintLine(p.ToString());
            }
        }
    }
}
