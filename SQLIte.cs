using System.Data.SQLite;
using System.Data;

namespace Intermediate_Exercises
{
    public class SQLIte
    {
        public static void CreateDatabase()
        {
            string dbFileName = "out.sqlite";

            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }

            using (SQLiteConnection connection = new SQLiteConnection(
                "Data Source=" + dbFileName + ";Version=3;"
            ))
            {
                connection.Open();

                string personTable = "create table if not exists person (name varchar(20), age int)";
                using (SQLiteCommand command = new SQLiteCommand(personTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                string teacherTable = "create table if not exists teacher (name varchar(20))";
                using (SQLiteCommand command = new SQLiteCommand(teacherTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public class Person
        {
            public string? Name { get; set; }
            public int Age { get; set; }
        }

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
                            Name = reader["name"].ToString()!,
                            Age = int.Parse(reader["age"].ToString()!)
                        }
                        );
                    }
                }
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
            }
        }
    }
}
