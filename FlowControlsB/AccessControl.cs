namespace IntermediateExercises.FlowControlsB
{
    using Base;

    public class AccessControl
    {
        public static void Login()
        {
            Printing.PrintLine("Try to login with the username and password");

            string expectedUser = "Joseph";
            string expectedPass = "12345";

            int attempts = 0;

            while (attempts < 3)
            {
                Printing.Print("Username: ");
                string username = InputChecker.InputString();

                Printing.Print("Password: ");
                string password = InputChecker.InputString();

                if (username == expectedUser && password == expectedPass)
                {
                    Printing.PrintLine("Login Successful!");
                }
                else
                {
                    Printing.PrintLine("Login Failed!");
                }
                attempts++;

                if (attempts == 3)
                {
                    Printing.PrintLine("You used all your attempts!");
                }
            }
        }
    }
}
