namespace IntermediateExercises.FlowControlsB
{
    public class AccessControl
    {
        public static void Login()
        {
            Console.WriteLine("Try to login with the username and password");

            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine()!;

                Console.Write("Password: ");
                string password = Console.ReadLine()!;

                if (username == "12" && password == "1234")
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                    Console.WriteLine("Login Failed!");
                }
                attempts++;

                if (attempts == 3)
                {
                    Console.WriteLine("You used all your attempts!");
                }
            }
        }
    }
}
