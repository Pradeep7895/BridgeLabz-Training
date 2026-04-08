using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.voting_system
{
    internal class VoteUtility
    {
        
        private Dictionary<string, int> voteCount = new Dictionary<string, int>();
        private List<string> voteOrder = new List<string>();

        // Cast Vote 
        public void CastVote()
        {
            Console.Write("Enter candidate name: ");
            string name = Console.ReadLine();

            voteOrder.Add(name);

            if (voteCount.ContainsKey(name))
                voteCount[name]++;
            else
                voteCount[name] = 1;

            Console.WriteLine("Vote cast successfully.");
        }

        // Display Vote Counts
        public void DisplayVoteCounts()
        {
            Console.WriteLine("\nVote Counts:");
            foreach (var v in voteCount)
                Console.WriteLine(v.Key + " : " + v.Value);
        }

        //Display Sorted Results
        public void DisplaySortedResults()
        {
            Console.WriteLine("\nSorted Results:");
            SortedDictionary<string, int> sorted = new SortedDictionary<string, int>(voteCount);

            foreach (var v in sorted)
                Console.WriteLine(v.Key + " : " + v.Value);
        }

        //Display Vote Order
        public void DisplayVoteOrder()
        {
            Console.WriteLine("\nVote Order:");
            foreach (string name in voteOrder)
                Console.Write(name + "-->");
            Console.WriteLine("END");
        }

    }
}

   