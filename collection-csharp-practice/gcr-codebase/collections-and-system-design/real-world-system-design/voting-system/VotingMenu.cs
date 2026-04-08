using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.voting_system
{
    internal class VotingMenu
    {

        private VoteUtility utility = new VoteUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n==== Voting System Menu ====");
                Console.WriteLine("1. Cast Vote");
                Console.WriteLine("2. Display Vote Counts");
                Console.WriteLine("3. Display Sorted Results");
                Console.WriteLine("4. Display Vote Order");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.CastVote();
                        break;

                    case 2:
                        utility.DisplayVoteCounts();
                        break;

                    case 3:
                        utility.DisplaySortedResults();
                        break;

                    case 4:
                        utility.DisplayVoteOrder();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Voting System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }

    }
}
