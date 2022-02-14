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
            string userInput_str = Console.ReadLine();
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
                    Console.WriteLine("Number of steps: " + steps);
                }

                catch (Exception)
                {

                    Console.WriteLine("Incorrect input. Enter an integer greater than 1.");
                    SolveConjecture();
                }
            }
            
        }
    }
}
