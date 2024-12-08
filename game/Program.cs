using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int computerScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors");

            while (playerScore != 3 && computerScore != 3)
            {
                Console.WriteLine("Player score: " + playerScore + " Computer score: " + computerScore);
                Console.WriteLine("Enter 'r' for rock, 'p' for paper, or 's' for scissors");
                string playerChoice = Console.ReadLine();

                int computerChoice = random.Next(0, 3);

                if (computerChoice == 0)
                {
                    Console.WriteLine("Computer chooses rock");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player won this round");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("Computer won this round");
                            computerScore++;
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else if (computerChoice == 1)
                {
                    Console.WriteLine("Computer chooses paper");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Computer won this round");
                            computerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie");
                            break;
                        case "s":
                            Console.WriteLine("Player won this round");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Computer chooses scissors");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player won this round");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Computer won this round");
                            computerScore++;
                            break;
                        case "s":
                            Console.WriteLine("Tie");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }
        }
    }
}