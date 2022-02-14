using System;
using System.Transactions;

namespace ColatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;

            while (!isQuit)
            {
                SolveConjecture();
                isQuit = Quit();
            }
        }

        private static void SolveConjecture()
        {
            Console.Write("\nEnter any positive integer greater than 1: ");
            string userInput_str = Console.ReadLine();
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

            Console.WriteLine("Number of steps: " + steps);
        }

        private static bool Quit()
        {
            Console.Write("\nEnter QUIT to exit or ENTER to test new number: ");
            string quit = Console.ReadLine();
            quit = quit.ToLower();
            if (quit == "quit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
