using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.social_media_friend_connections
{
    internal class SocialList
    {
        // Head points to first user
        private UserNode head;

        // Add a new user at beginning
        public void AddUser(int id, string name, int age)
        {
            // Create new user node
            UserNode newUser = new UserNode(id, name, age);

            // Link new user to current head
            newUser.Next = head;

            // Move head to new user
            head = newUser;
        }

        // Find user by User ID
        private UserNode FindUserById(int id)
        {
            // Start from head
            UserNode temp = head;

            // Traverse list
            while (temp != null)
            {
                if (temp.UserId == id)
                    return temp;

                // move to next user
                temp = temp.Next;    
            }

            return null;            
        }


        // 1️. Add friend connection between two users
        public void AddFriend(int id1, int id2)
        {
            // Find both users
            UserNode user1 = FindUserById(id1);
            UserNode user2 = FindUserById(id2);

            // If any user not found
            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            // Add friend id if not already added
            if (!user1.Friends.Contains(id2))
                user1.Friends.Add(id2);

            if (!user2.Friends.Contains(id1))
                user2.Friends.Add(id1);

            Console.WriteLine("Friend connection added");
        }

        // 2️. Remove friend connection
        public void RemoveFriend(int id1, int id2)
        {
            // Find both users
            UserNode user1 = FindUserById(id1);
            UserNode user2 = FindUserById(id2);

            // If any user not found
            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            // Remove friend IDs
            user1.Friends.Remove(id2);
            user2.Friends.Remove(id1);

            Console.WriteLine("Friend connection removed");
        }

        // 3️. Find mutual friends
        public void FindMutualFriends(int id1, int id2)
        {
            // Find both users
            UserNode user1 = FindUserById(id1);
            UserNode user2 = FindUserById(id2);

            // If any user not found
            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine("Mutual Friends:");

            // Check common friend IDs
            foreach (int f in user1.Friends)
            {
                if (user2.Friends.Contains(f))
                    Console.WriteLine("Friend ID: " + f);
            }
        }

        // 4️. Display all friends of a user
        public void DisplayFriends(int id)
        {
            // Find user
            UserNode user = FindUserById(id);

            // If user not found
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine("Friends of " + user.Name + ":");

            // Print friend IDs
            foreach (int f in user.Friends)
            {
                Console.WriteLine("Friend ID: " + f);
            }
        }

        // 5️. Search user by ID
        public void SearchById(int id)
        {
            UserNode user = FindUserById(id);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            // Print user details
            PrintUser(user);
        }

        // 6️. Search user by Name
        public void SearchByName(string name)
        {
            UserNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Name == name)
                {
                    PrintUser(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("User not found");
        }

        // 7️. Count friends for each user
        public void CountFriends()
        {
            UserNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(
                    temp.Name + " has " + temp.Friends.Count + " friends");
                temp = temp.Next;
            }
        }

        // Print one user
        private void PrintUser(UserNode u)
        {
            Console.WriteLine(
                "ID: " + u.UserId +
                ", Name: " + u.Name +
                ", Age: " + u.Age
            );
        }

    }
}

    