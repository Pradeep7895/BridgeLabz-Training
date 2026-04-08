using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.stack_queues_hashmap_hashfunctions
{
    internal class CustomHashMap
    {
        // Node to store key-value pair
        class Node
        {
            public int Key;
            public int Value;

            public Node(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }

        private int capacity;
        private LinkedList<Node>[] buckets;

        // Constructor
        public CustomHashMap(int capacity = 10)
        {
            this.capacity = capacity;
            buckets = new LinkedList<Node>[capacity];

            // Initialize each bucket
            for (int i = 0; i < capacity; i++)
            {
                buckets[i] = new LinkedList<Node>();
            }
        }

        // Hash function to get index
        private int GetIndex(int key)
        {
            return Math.Abs(key.GetHashCode()) % capacity;
        }

        // Insert or update key-value pair
        public void Put(int key, int value)
        {
            int index = GetIndex(key);

            // Check if key already exists
            foreach (var node in buckets[index])
            {
                if (node.Key == key)
                {
                    node.Value = value; // update value
                    return;
                }
            }

            // If key not found, add new node
            buckets[index].AddLast(new Node(key, value));
        }

        // Retrieve value by key
        public int Get(int key)
        {
            int index = GetIndex(key);

            foreach (var node in buckets[index])
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
            }

            // Key not found
            return -1;
        }

        // Remove key-value pair
        public void Remove(int key)
        {
            int index = GetIndex(key);

            var bucket = buckets[index];
            var current = bucket.First;

            while (current != null)
            {
                if (current.Value.Key == key)
                {
                    bucket.Remove(current);
                    return;
                }
                current = current.Next;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            CustomHashMap map = new CustomHashMap();

            map.Put(1, 10);
            map.Put(2, 20);
            // collision example
            map.Put(12, 120); 

            Console.WriteLine(map.Get(1));   // 10
            Console.WriteLine(map.Get(2));   // 20
            Console.WriteLine(map.Get(12));  // 120

            map.Remove(2);
            Console.WriteLine(map.Get(2));   // -1
        }
    }

}



