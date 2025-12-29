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

        // Random number generator
        static Random random = new Random();

        static void Main(string[] args)
        {
            // Main menu loop
            int choice;
            bool exit = false;

            // Using do-while loop for menu
            do
            {
                Console.Clear();
                Console.WriteLine(" Snake & Ladder Game");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Start New Game");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                // Read user choice
                choice = Convert.ToInt32(Console.ReadLine());

                // Switch-case for menu options
                switch (choice)
                {
                    //start game
                    case 1:
                        StartGame();
                        break;

                    //exit
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

            // Get number of players
            int playerCount = GetPlayerCount();

            // Initialize player names and positions
            string[] playerNames = new string[playerCount];
            int[] playerPositions = new int[playerCount];

            //get player name and set initial position to 0
            for (int i = 0; i < playerCount; i++)
            {
                Console.Write($"Enter name of Player {i + 1}: ");
                playerNames[i] = Console.ReadLine();
                playerPositions[i] = 0;
            }
            // Game loop
            bool gameWon = false;

            while (!gameWon)
            {
                // Each player's turn
                for (int i = 0; i < playerCount; i++)
                {
                    
                    Console.WriteLine($"\n {playerNames[i]}'s turn. Press Enter to roll dice...");
                    Console.ReadLine();

                    //roll dice to get number between 1 to 6
                    int dice = RollDice();
                    // Get old position
                    int oldPos = playerPositions[i];

                    // Ternary operator
                    int tentativePos = (oldPos + dice <= 100) ? oldPos + dice : oldPos;

                    // Check if move is valid
                    if (tentativePos == oldPos)
                    {
                        //move exceeds 100
                        Console.WriteLine($" Dice: {dice} | Move skipped (exceeds 100)");
                        continue;
                    }

                    // Apply snakes or ladders and update position
                    int finalPos = ApplySnakeOrLadder(tentativePos);
                    playerPositions[i] = finalPos;

                    // Display move details
                    Console.WriteLine($"Dice: {dice}");
                    Console.WriteLine($"Position: {oldPos} --> {finalPos}");

                    // Check for win condition
                    if (CheckWin(finalPos))
                    {
                        Console.WriteLine($"\n {playerNames[i]} wins the game!");
                        gameWon = true;
                        break;
                    }
                }
            }

            // End of game
            Console.WriteLine("\nGame Over! Press Enter to return to menu...");
            Console.ReadLine();
        }

        // Get number of players between 2 and 4
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
        // Roll dice to get a number between 1 and 6
        static int RollDice()
        {
            return random.Next(1, 7);
        }
        // Apply snakes or ladders based on position
        // Returns new position
        static int ApplySnakeOrLadder(int position)
        {
            for (int i = 0; i < ladderFrom.Length; i++)
            {
                //check for ladder
                if (position == ladderFrom[i])
                {
                    Console.WriteLine(" Ladder! Climb up.");
                    return ladderTo[i];
                }
            }
            //check for snake
            
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
        // Check if position is winning position
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


