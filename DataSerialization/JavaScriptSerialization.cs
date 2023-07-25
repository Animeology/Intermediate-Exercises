namespace IntermediateExercises.DataSerialization
{
    using Base;
    using Nancy.Json;
    using Structures;
    using System.IO;    

    public class JavaScriptSerialization
    {
        static void Serialize(Person person)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string fileName = "JavaScriptSerialization.json";

            string json = jsSerializer.Serialize(person);

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(json);
            }
        }

        static Person Deserialize()
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string fileName = "JavaScriptSerialization.json";

            using (StreamReader sr = new StreamReader(fileName))
            {
                string json = sr.ReadToEnd();
                return jsSerializer.Deserialize<Person>(json);
            }
        }

        public static void CreatePersonInJSSerialization()
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
