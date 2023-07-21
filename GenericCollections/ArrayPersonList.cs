using System.Collections;

namespace IntermediateExercises.GenericCollections
{
    using Base;
    using Structures;

    public class ArrayPersonList
    {
        ArrayList list = new ArrayList();

        const int ARRAY_COUNT = 3;
        void CreatePerson()
        {
            Printing.PrintLine("Create three Person with their name and age and it will print the three Person");

            for (int i = 0; i < ARRAY_COUNT; i++)
            {
                string name = InputChecker.InputStringOnlyLetters();
                int age = InputChecker.InputInt();

                list.Add(new Person()
                {
                    m_name = name,
                    m_age = age
                });
            }            
        }

        public void PrintPerson()
        {
            CreatePerson();

            foreach (Person p in list)
            {
                Printing.PrintLine(p.ToString());
            }
        }
    }
}
