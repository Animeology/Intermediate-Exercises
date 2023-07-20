using System.Data.SQLite;
using System.Data;

namespace IntermediateExercises.SQLite
{
    public class CRUD
    {
        public static void CRUDMenu()
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

        static int Menu()
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

        //void CreateTable(string file)
        //{
        //    string NEWLINE = "\n";
        //    string INDENT = "\t";

        //    using (SQLiteConnection conn = new SQLiteConnection(
        //        "Data Source=" + file + ";Version=3;"))
        //    {
        //        conn.Open();

        //        string sql =
        //            $"create table if not exists person {NEWLINE}" +
        //            $"{{ {NEWLINE}" +
        //            $"{INDENT}int primary key autoincrement, {NEWLINE}" +
        //            $"{INDENT}name varchar(20), {NEWLINE}" +
        //            $"{INDENT}age int {NEWLINE}" +
        //            $"}} {NEWLINE}";

        //        using (SQLiteCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        static void Add(string file)
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

        static void Show(string file)
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

        static void Edit(string file)
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

        static void Delete(string file)
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

        static bool CheckForEntry(int id, string file)
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
    }
}
