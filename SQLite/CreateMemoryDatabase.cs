using System.Data.SQLite;

namespace IntermediateExercises.SQLite
{
    public class CreateMemoryDatabase
    {
        public static void CreateMemoryDB()
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
    }
}
