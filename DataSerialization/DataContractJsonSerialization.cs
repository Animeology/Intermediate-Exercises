namespace IntermediateExercises.DataSerialization
{
    using Base;
    using Structures;
    using System.Runtime.Serialization.Json;

    public class DataContractJsonSerialization
    {
        public static void Serialize(Person person)
        {
            string fileName = "DataContractSerialization.json";

            using (Stream stream = new FileStream(
                    fileName, 
                    FileMode.Create, 
                    FileAccess.Write
                ))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
                serializer.WriteObject(stream, person);
            }
        }

        public static Person Deserialize()
        {
            string fileName = "DataContractSerialization.json";

            using (Stream stream = new FileStream(
                    fileName, 
                    FileMode.Open, 
                    FileAccess.Read
                ))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
                return (Person)serializer.ReadObject(stream)!;
            }
        }

        public static void CreatePersonInDataContractSerialization()
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

