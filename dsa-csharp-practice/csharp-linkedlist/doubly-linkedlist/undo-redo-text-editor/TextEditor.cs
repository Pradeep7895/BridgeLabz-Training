using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.undo_redo_text_editor
{
    internal class TextEditor
    {
        
        private TextState head;
        private TextState current;

        // Maximum history size
        private int maxSize = 10;

        // Current size of history
        private int size = 0;

        // 1️. Add new text state
        public void AddState(string text)
        {
            // Create new state
            TextState newState = new TextState(text);

            // If no state exists
            if (head == null)
            {
                head = current = newState;
                size = 1;
                return;
            }

            // Remove redo states
            if (current.Next != null)
            {
                current.Next.Prev = null;
                current.Next = null;
            }

            // Link new state after current
            current.Next = newState;
            newState.Prev = current;
            current = newState;
            size++;

            // If history exceeds limit
            if (size > maxSize)
            {
                // Remove first state
                head = head.Next;
                head.Prev = null;
                size--;
            }
        }

        // 2️. Undo operation
        public void Undo()
        {
            // If no previous state
            if (current == null || current.Prev == null)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            // Move to previous state
            current = current.Prev;
        }

        // 3️. Redo operation
        public void Redo()
        {
            // If no next state
            if (current == null || current.Next == null)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            // Move to next state
            current = current.Next;
        }

        // 4️. Display current text
        public void DisplayCurrentText()
        {
            if (current == null)
            {
                Console.WriteLine("Text is empty");
                return;
            }

            Console.WriteLine("Current Text: " + current.Content);
        }

    }
}

   