using System;
using System.Transactions;

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

        private static void SolveConjecture()
        {
            Console.Write("\nEnter any positive integer greater than 1 or type QUIT to exit: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string userInput_str = Console.ReadLine();
            Console.ResetColor();
            userInput_str = userInput_str.ToLower();

            if (userInput_str == "quit")
            {
                isQuit = true;
            }
            else
            {
                try
                {
                    int n = int.Parse(userInput_str);

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Number of steps: " + steps);
                    Console.ResetColor();
                }

                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect input. Enter an integer greater than 1.");
                    Console.ResetColor();
                    SolveConjecture();
                }
            }
            
        }
    }
}
