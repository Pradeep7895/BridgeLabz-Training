using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenario_based
{
    internal class SnakeAndLadder
    {
        // Fixed snakes and ladders using arrays only
        static int[] snakeFrom = { 99, 70, 52, 25 };
        static int[] snakeTo = { 41, 55, 29, 2 };

        static int[] ladderFrom = { 6, 11, 60, 46 };
        static int[] ladderTo = { 25, 40, 85, 90 };

        static Random random = new Random();

        static void Main(string[] args)
        {
            int choice;
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine(" Snake & Ladder Game");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Start New Game");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        StartGame();
                        break;

                    case 2:
                        Console.WriteLine("Exiting game. Thank you for playing!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }

            } while (!exit);
        }

        static void StartGame()
        {

            int playerCount = GetPlayerCount();

            string[] playerNames = new string[playerCount];
            int[] playerPositions = new int[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                Console.Write($"Enter name of Player {i + 1}: ");
                playerNames[i] = Console.ReadLine();
                playerPositions[i] = 0;
            }

            bool gameWon = false;

            while (!gameWon)
            {
                for (int i = 0; i < playerCount; i++)
                {
                    Console.WriteLine($"\n {playerNames[i]}'s turn. Press Enter to roll dice...");
                    Console.ReadLine();

                    int dice = RollDice();
                    int oldPos = playerPositions[i];

                    // Ternary operator
                    int tentativePos = (oldPos + dice <= 100) ? oldPos + dice : oldPos;

                    if (tentativePos == oldPos)
                    {
                        Console.WriteLine($" Dice: {dice} | Move skipped (exceeds 100)");
                        continue;
                    }

                    int finalPos = ApplySnakeOrLadder(tentativePos);
                    playerPositions[i] = finalPos;

                    Console.WriteLine($"Dice: {dice}");
                    Console.WriteLine($"Position: {oldPos} --> {finalPos}");

                    if (CheckWin(finalPos))
                    {
                        Console.WriteLine($"\n {playerNames[i]} wins the game!");
                        gameWon = true;
                        break;
                    }
                }
            }

            Console.WriteLine("\nGame Over! Press Enter to return to menu...");
            Console.ReadLine();
        }

        static int GetPlayerCount()
        {
            int count;
            do
            {
                Console.Write("Enter number of players (2–4): ");
                count = Convert.ToInt32(Console.ReadLine());
            }
            while (count < 2 || count > 4);

            return count;
        }

        static int RollDice()
        {
            return random.Next(1, 7);
        }

        static int ApplySnakeOrLadder(int position)
        {
            for (int i = 0; i < ladderFrom.Length; i++)
            {
                if (position == ladderFrom[i])
                {
                    Console.WriteLine(" Ladder! Climb up.");
                    return ladderTo[i];
                }
            }

            for (int i = 0; i < snakeFrom.Length; i++)
            {
                if (position == snakeFrom[i])
                {
                    Console.WriteLine(" Snake! Slide down.");
                    return snakeTo[i];
                }
            }

            return position;
        }

        static bool CheckWin(int position)
        {
            switch (position)
            {
                case 100:
                    return true;
                default:
                    return false;
            }
        }
    }
}


