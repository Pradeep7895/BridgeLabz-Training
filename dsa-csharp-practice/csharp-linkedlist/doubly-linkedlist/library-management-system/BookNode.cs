using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.library_management_system
{
    internal class BookNode
    {
        // Book details
        public int BookId;             
        public string Title;          
        public string Author;         
        public string Genre;         
        public bool IsAvailable;      

        // Links for doubly linked list
        public BookNode Next;            
        public BookNode Prev;           

        // Constructor to assign values
        public BookNode(int id, string title, string author, string genre, bool available)
        {
            BookId = id;                
            Title = title;        
            Author = author;        
            Genre = genre;           
            IsAvailable = available;   
            Next = null;             
            Prev = null;               
        }

    }
}

    