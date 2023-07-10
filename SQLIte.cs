using System.Data.SQLite;
using System.Data;

namespace Intermediate_Exercises
{
    public class SQLIte
    {
        public void CRUD()
        {
            string fileName = "mockDatabase.sqlite";

            if (!File.Exists(fileName))
            {
                SQLiteConnection.CreateFile(fileName);
            }

            using (SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + 
                fileName + 
                ";Version=3;"))
            {
                conn.Open();

                int choice = Menu();

                switch(choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }


        }

        public int Menu()
        {
            int choice = 0;

            Console.WriteLine("Choose an option for the database");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Edit");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        public void CreateMemoryDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(
                    "Data Source=" + 
                    ":memory:" + 
                    ";Version=3;" + 
                    "New=True"
                )
            )
            {
                connection.Open();

                string personTableString = "create table person (name varchar(20), age int)";
                using (SQLiteCommand command = new SQLiteCommand(personTableString, connection))
                {
                    command.ExecuteNonQuery();
                }

                string teacherTableString = "create table teacher (name varchar(20))";
                using (SQLiteCommand command = new SQLiteCommand(teacherTableString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateDatabase()
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

        public void ReadingListFromDB()
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
