using System;

namespace ColatzConjecture
{
    class Program
    {
        static bool isQuit = false;

        static void Main(string[] args)
        {
            while (!isQuit)
            {
                SolveConjecture();
            }
        }

        /* Method to perform calculations for Colatz Conjecture
         * Counts how many steps it takes to get to one */
        private static void SolveConjecture()
        {
            string userInput_str = GetUserInput();

            if (userInput_str == "quit")
            {
                isQuit = true;
            }
            else
            {
                // Try to convert unser input to integer
                try
                {
                    Calculation(userInput_str);
                }

                catch (Exception)
                {
                    DisplayError();
                }
            }

        }

        private static string GetUserInput()
        {
            // Ask user for input
            Console.Write("\nEnter any positive integer greater than 1 or type QUIT to exit: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            return Console.ReadLine().ToLower();
        }

        private static void Calculation(string userInput_str)
        {
            int n = int.Parse(userInput_str);

            if (n > 1 && n < int.MaxValue)
            {
                int steps = 0;

                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        steps++;
                    }
                    else
                    {
                        n *= 3;
                        n += 1;
                        steps++;
                    }
                }

                DisplayResult(steps);
            }
            else
            {
                DisplayError();
            }
        }

        private static void DisplayResult(int steps)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // Display result
            Console.WriteLine("Number of steps: " + steps);

            Console.ResetColor();
        }

        private static void DisplayError()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            // Warn user of incorrect input
            Console.WriteLine("Incorrect input. Enter an integer greater than 1.");

            Console.ResetColor();
        }
    }
}
