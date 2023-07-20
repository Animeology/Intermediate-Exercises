using System.Data.SQLite;
using System.Data;

namespace IntermediateExercises.SQLite
{
    using Structures;

    public class ReadingTheDatabase
    {
        public static void ReadingListFromDB()
        {
            string dbFileName = "persons.sqlite";
            List<Person> persons = new List<Person>();

            using (SQLiteConnection connection = new SQLiteConnection(
                "Data Source=" + dbFileName + ";Version=3;"
            ))
            {
                connection.Open();

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select name, age from \"person\"";
                    command.CommandType = CommandType.Text;

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        persons.Add(new Person()
                        {
                            m_name = reader["name"].ToString()!,
                            m_age = int.Parse(reader["age"].ToString()!)
                        }
                        );
                    }
                }
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.m_name);
                Console.WriteLine(person.m_age);
            }
        }
    }
}
