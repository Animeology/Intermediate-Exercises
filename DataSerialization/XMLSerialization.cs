namespace IntermediateExercises.DataSerialization
{
    using Base;
    using Structures;
    using System.Xml.Serialization;

    public class XMLSerialization
    {
        static void Serialize(Person person)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            string fileName = "XML Serialization.xml";

            using (Stream stream = new FileStream(
                    fileName,
                    FileMode.Create,
                    FileAccess.Write
                ))
            {
                xmlSerializer.Serialize(stream, person);
            }
        }

        static Person Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            string fileName = "XML Serialization.xml";

            using (Stream stream = new FileStream(
                    fileName,
                    FileMode.Open,
                    FileAccess.Read
                ))
            {
                return (Person)xmlSerializer.Deserialize(stream)!;
            }
        }

        public static void CreatePersonInXMLSerialization()
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
