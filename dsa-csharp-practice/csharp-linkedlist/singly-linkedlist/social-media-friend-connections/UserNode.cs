using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.social_media_friend_connections
{
    internal class UserNode
    {
        // User details
        public int UserId;
        public string Name;
        public int Age;

        // List of friend IDs
        public List<int> Friends;

        // Link to next user
        public UserNode Next;

        // Constructor
        public UserNode(int id, string name, int age)
        {
            UserId = id;            
            Name = name;            
            Age = age;              
            Friends = new List<int>(); 
            Next = null;           
        }

    }
}


    