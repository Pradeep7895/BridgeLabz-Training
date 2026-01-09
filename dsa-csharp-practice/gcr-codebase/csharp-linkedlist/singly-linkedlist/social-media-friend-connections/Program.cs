using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.social_media_friend_connections
{
    internal class Program
    {
        static void Main()
        {
            // Create social network
            SocialList network = new SocialList();

            // Add users
            network.AddUser(1, "Amit", 22);
            network.AddUser(2, "Neha", 21);
            network.AddUser(3, "Rahul", 23);

            // Add friends
            network.AddFriend(1, 2);
            network.AddFriend(1, 3);
            network.AddFriend(2, 3);

            // Display friends
            network.DisplayFriends(1);

            // Mutual friends
            Console.WriteLine("\nMutual Friends of 1 and 2:");
            network.FindMutualFriends(1, 2);

            // Search user
            Console.WriteLine("\nSearch by Name:");
            network.SearchByName("Rahul");

            // Count friends
            Console.WriteLine("\nFriend Count:");
            network.CountFriends();
        }

    }
}

    