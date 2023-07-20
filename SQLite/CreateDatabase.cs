using System.Data.SQLite;

namespace IntermediateExercises.SQLite
{
    public class CreateDatabase
    {
        public static void CreationDB()
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
    }
}
