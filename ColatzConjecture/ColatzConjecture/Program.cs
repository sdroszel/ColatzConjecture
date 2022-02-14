using System;
using System.Transactions;

namespace ColatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            string quit = "";

            while (!isQuit)
            {
                Console.WriteLine("Number of steps: " + SolveConjecture());
                Console.Write("Enter QUIT to exit or ENTER to test new number: ");
                quit = Console.ReadLine();
                quit = quit.ToLower();
                if (quit == "quit")
                {
                    isQuit = true;
                }
                else
                {
                    continue;
                }
            }
        }

        private static int SolveConjecture()
        {
            Console.Write("Enter any positive integer greater than 1: ");
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

            return steps;
        }
    }
}
