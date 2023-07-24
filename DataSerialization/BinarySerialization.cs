
namespace IntermediateExercises.DataSerialization
{
    using Base;
    using Structures;
    using System.Runtime.Serialization.Formatters.Binary;
    
    public class BinarySerialization
    {
        static void Serialize(Person person)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string fileName = "binarySerialization.json";

            using (Stream stream = new FileStream(
                    fileName,
                    FileMode.Create,
                    FileAccess.Write
                  ))
            {
#pragma warning disable SYSLIB0011
                bf.Serialize(stream, person);
#pragma warning restore SYSLIB0011
            }
        }

        static Person Deserialize()
        {
            BinaryFormatter bf = new BinaryFormatter();
            string fileName = "binarySerialization.json";

            using (Stream stream = new FileStream(
                    fileName,
                    FileMode.Open,
                    FileAccess.Read
                  ))
            {
#pragma warning disable SYSLIB0011
                return (Person)bf.Deserialize(stream);
#pragma warning restore SYSLIB0011
            }
        }

        public static void CreatePersonInBinarySerialization()
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
