using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.StreamBuzz
{
    internal class Menu
    {
        private readonly IEngagement _utility;

        public Menu(IEngagement utility)
        {
            _utility = utility;
        }

        public void Start()
        {
            while (true)
            {
                PrintMenu();
                int choice = ReadInt("Enter your choice:");

                switch (choice)
                {
                    case 1:
                        HandleRegisterCreator();
                        break;

                    case 2:
                        HandleShowTopPosts();
                        break;

                    case 3:
                        HandleAverageLikes();
                        break;

                    case 4:
                        return;

                    default:
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }

        private void HandleRegisterCreator()
        {
            Console.WriteLine("Enter Creator Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter weekly likes (Week 1 to 4):");
            double[] likes = new double[4];
            for (int i = 0; i < 4; i++)
            {
                likes[i] = ReadDouble("");
            }

            CreatorStats record = new CreatorStats
            {
                CreatorName = name,
                WeeklyLikes = likes
            };

            _utility.RegisterCreator(record);
            Console.WriteLine("Creator registered successfully");
            Console.WriteLine();
        }

        private void HandleShowTopPosts()
        {
            double threshold = ReadDouble("Enter like threshold:");

            Dictionary<string, int> result =
                _utility.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

            if (result.Count == 0)
            {
                Console.WriteLine("No top-performing posts this week");
            }
            else
            {
                foreach (var kvp in result)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }

            Console.WriteLine();
        }

        private void HandleAverageLikes()
        {
            double avg = _utility.CalculateAverageLikes();
            Console.WriteLine($"Overall average weekly likes: {avg}");
            Console.WriteLine();
        }

        private int ReadInt(string prompt)
        {
            if (!string.IsNullOrWhiteSpace(prompt))
                Console.WriteLine(prompt);

            int val;
            while (!int.TryParse(Console.ReadLine(), out val))
            {
            }
            return val;
        }

        private double ReadDouble(string prompt)
        {
            if (!string.IsNullOrWhiteSpace(prompt))
                Console.WriteLine(prompt);

            double val;
            while (!double.TryParse(Console.ReadLine(), out val))
            {
            }
            return val;
        }
    }
}