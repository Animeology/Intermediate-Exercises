namespace IntermediateExercises.DataSerialization
{
    using Base;
    using Structures;
    using Newtonsoft.Json;
    using System;

    public class NewtonsoftSerialization
    {
        static void Serialize(Person person)
        {
            string fileName = "NewtonsoftSerialization.json";
            string json = JsonConvert.SerializeObject(person);

            File.WriteAllText(fileName, json);
        }

        static Person Deserialize()
        {
            string fileName = "NewtonsoftSerialization.json";
            string json = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<Person>(json)!;
        }

        public static void CreatePersonInNewtonsoftSerialization()
        {
            Printing.PrintLine("Create a Person with a name, age, and the city which also has a name and population number");

            string name = InputChecker.InputStringOnlyLetters();
            int age = InputChecker.InputInt();
            string cityName = InputChecker.InputStringOnlyLetters();
            int population = InputChecker.InputInt();

            Person person = new Person()
            {
                m_name = name,
                m_age = age,
                city = new City()
                {
                    Name = cityName,
                    Population = population
                }
            };

            Serialize(person);
            person = Deserialize();

            Printing.PrintLine(person.ToString());
        }

    }
}
