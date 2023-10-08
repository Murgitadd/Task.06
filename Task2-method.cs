using System;

namespace CodingOlympics
{
    class Program
    {
        static void Main(string[] args)
        {
            string competitor1 = "Rashad";
            string competitor2 = "Aydan";
            int competitor1Score = 0;
            int competitor2Score = 0;
            int numberOfRounds = 3;

            Console.WriteLine("Welcome to the Great Olympics of AB104!");
            
            for (int round = 1; round <= numberOfRounds; round++)
            {
                Console.WriteLine($"~~~~Round {round} of 3~~~~");
                
                Console.Write($"Rate {competitor1}: ");
                int points1 = int.Parse(Console.ReadLine());

                Console.Write($"Rate {competitor2}: ");
                int points2 = int.Parse(Console.ReadLine());

                if (points1 > points2)
                {
                    Console.WriteLine($"{competitor1} wins this round!");
                    competitor1Score++;
                }
                else if (points2 > points1)
                {
                    Console.WriteLine($"{competitor2} wins this round!");
                    competitor2Score++;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Game Over!");

            if (competitor1Score > competitor2Score)
            {
                Console.WriteLine($"{competitor1} wins with a total score of {competitor1Score}!");
            }
            else if (competitor2Score > competitor1Score)
            {
                Console.WriteLine($"{competitor2} wins with a total score of {competitor2Score}!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
