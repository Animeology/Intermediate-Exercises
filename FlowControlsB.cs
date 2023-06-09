﻿namespace Intermediate_Exercises
{
    public class FlowControlsB
    {
        public void RepetitiveStructures()
        {
            Console.WriteLine("Input two numbers and it will show the range between these two numbers included the two inputs");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            // For Loop
            for (int i = x; i <= y; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            // While loop
            int loop = x;
            while (loop <= y)
            {
                Console.Write("{0} ", loop);
                loop++;
            }

            Console.WriteLine();

            // Do While loop
            int j = x;
            do
            {
                Console.Write("{0} ", j);
                j++;
            } while (j <= y);
        }

        public void InfiniteDivide()
        {
            Console.WriteLine("Input two numbers and it would keep dividing until the first input is 0");

            int num1;
            int num2;

            do
            {
                num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 != 0)
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("You cannot divide by 0");
                    }
                    else
                    {
                        int result = num1 / num2;
                        Console.WriteLine("The division is {0}", result);
                        Console.WriteLine("The rest is {0}", num1 % num2);
                    }
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }

            } while (num1 != 0);
        }

        public void AccessControl()
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

        public void MultipleThreesAndFives()
        {
            Console.WriteLine("Prints out numbers ranged from 1 to 500 that are multiples of 3 and 5");

            int x = 1;
            int y = 500;

            for (int i = x; i <= y; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
