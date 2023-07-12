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
                "Data Source=" + fileName + ";Version=3;"))
            {
                conn.Open();

                do
                switch (Menu())
                {
                    case 1:
                        Add(fileName);
                        break;
                    case 2:
                        Show(fileName);
                        break;
                    case 3:
                        Edit(fileName);
                        break;
                    case 4:
                        Delete(fileName);
                        break;
                    case 5:
                        break;
                } while (Menu() != 5);
            }
        }

        public int Menu()
        {
            Console.WriteLine("Choose an option for the database");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Edit");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");

            Console.Write("Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        public void CreateTable(string file)
        {
            string NEWLINE = "\n";
            string INDENT = "\t";

            using (SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;"))
            {
                conn.Open();

                string sql =
                    $"create table if not exists person {NEWLINE}" +
                    $"{{ {NEWLINE}" +
                    $"{INDENT}int primary key autoincrement, {NEWLINE}" +
                    $"{INDENT}name varchar(20), {NEWLINE}" +
                    $"{INDENT}age int {NEWLINE}" +
                    $"}} {NEWLINE}";

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Add(string file)
        {
            Console.Clear();
            Console.WriteLine("Add:");
            Console.WriteLine();

            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            using (SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;"))
            {
                conn.Open();

                string addString = "insert into persons table (name, age) entry: {" + name + ", " + age + "}";
                using (SQLiteCommand cmd = new SQLiteCommand(addString, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Show(string file)
        {
            Console.Clear();
            Console.WriteLine("Show:");
            Console.WriteLine();

            using (SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from person";
                    cmd.CommandType = CommandType.Text;
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("ID: " + reader["id"].ToString());
                        Console.WriteLine("Name: " + reader["name"].ToString());
                        Console.WriteLine("Age: " + reader["age"].ToString());
                        Console.WriteLine();
                    }
                }
            }
        }

        public void Edit(string file)
        {
            Console.Clear();
            Console.WriteLine("Edit:");
            Console.WriteLine();

            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (CheckForEntry(id, file))
            {
                Console.Write("Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                using (SQLiteConnection conn = new SQLiteConnection(
                    "Data Source=" + file + ";Version=3;"))
                {
                    conn.Open();

                    string editString = $"entry updated {id}: name: {name}, age: {age}";
                    using (SQLiteCommand cmd = new SQLiteCommand(editString, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Console.WriteLine($"{id} entry doesn't exist in the database");
            }
        }

        public void Delete(string file)
        {
            Console.Clear();
            Console.WriteLine("Delete:");
            Console.WriteLine();

            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (CheckForEntry(id, file))
            {
                using (SQLiteConnection conn = new SQLiteConnection(
                    "Data Source=" + file + ";Version=3;"))
                {
                    conn.Open();

                    string deleteString = $"entry {id} deleted ";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteString, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Console.WriteLine($"{id} entry doesn't exist in the database");
            }
        }

        public bool CheckForEntry(int id, string file)
        {
            bool existChecker = false;

            using (SQLiteConnection conn = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;"
                )
            )
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Find if id exists in the database";
                    cmd.CommandType = CommandType.Text;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["total"].ToString() == "1")
                        {
                            existChecker = true;
                        }
                    }
                }
            }

            return existChecker;
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
