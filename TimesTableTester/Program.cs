using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTableTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("Times Tables Tester");
                Console.Write("Enter your name: ");

                string userName = Console.ReadLine();

                int timestable = 0;
                int score = 0;

                var timer = new System.Diagnostics.Stopwatch();

                while (true)
                {
                    Console.Write("\n" + userName + ", which times table do you want to test yourself on? (2 - 12): ");

                    timestable = int.Parse(Console.ReadLine());

                    if ( (timestable >= 2) && (timestable <= 12) )

                    {
                        timer.Start();
                        break;
                    }
                    else if (timestable < 2)

                    {
                        Console.WriteLine("Entered times table is too low, try again.. \n");
                    }
                    else if (timestable > 12)
                    {
                        Console.WriteLine("Entered times table is too high, try again.. \n");
                    }
                }

                

                for (int indexer = 0; indexer < 10; indexer++)
                {
                    Console.Clear();

                    Random RNG = new Random();
                    int randomNumber = RNG.Next(2, 12);

                    Console.Write("" + userName + ", what is " + timestable + " x " + randomNumber + "?\nAnswer: ");
                    int answer = int.Parse(Console.ReadLine());
                    

                    if (answer == (randomNumber * timestable))
                    {
                        score++;
                        
                    }


                }

                timer.Stop();

                Console.Clear();

                if (score <= 3)
                {
                    Console.WriteLine("You got " + score + "/10 questions right, " + userName + ". Try to practice more!");
                }
                else if (score <= 6)
                {
                    Console.WriteLine("You got " + score + "/10 questions right, " + userName + ". That's alright but theres room for improvement! ");
                }
                else if (score <= 9)
                {
                    Console.WriteLine("You got " + score + "/10 questions right, " + userName + ". Good score, but still not perfect!");
                }
                else if (score == 10)
                {
                    Console.WriteLine("You got " + score + "/10 questions right, " + userName + ". A perfect score, congratulations!");
                }

                TimeSpan timeTaken = timer.Elapsed;

                Console.WriteLine("Test time: " + timeTaken.TotalSeconds + " seconds.");
                Console.Write("\nDo you want to play again? (y/n): ");
                string playagain = Console.ReadLine();

                if (playagain == "n")
                {
                    break;
                }


            }

        }
    }
}
