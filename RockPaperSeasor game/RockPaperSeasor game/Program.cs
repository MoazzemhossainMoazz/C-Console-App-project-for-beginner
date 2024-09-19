using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSeasor_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to the game!");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score-" + playerScore + "Enemy Score-" + enemyScore);
                Console.WriteLine("Please enter r for rock, p for paper or anything else for seasor");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy choose rock.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy win!");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy choose paper");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy win!");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        case "s":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy choose seasor.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy win!");
                            enemyScore++;
                            break;
                        case "s":
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
                
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }

        }

    }
}
