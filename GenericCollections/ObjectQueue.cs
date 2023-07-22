namespace IntermediateExercises.GenericCollections
{
    using Base;
    using Structures;
    using System.Collections.Generic;

    public class ObjectQueue
    {
        Queue<Person> queue = new Queue<Person>();

        const int ARRAY_COUNT = 3;

        void CreatePersonInQueue()
        {
            Printing.PrintLine("Create three Person with their name and age and it will print the three Person");

            for (int i = 0; i < ARRAY_COUNT; i++)
            {
                string name = InputChecker.InputStringOnlyLetters();
                int age = InputChecker.InputInt();

                queue.Enqueue(new Person()
                {
                    m_name = name,
                    m_age = age
                });
            }
        }

        public void PrintPersonInQueue()
        {
            CreatePersonInQueue();

            foreach (Person p in queue)
            {
                Printing.PrintLine(p.ToString());
            }
        }
    }
}
