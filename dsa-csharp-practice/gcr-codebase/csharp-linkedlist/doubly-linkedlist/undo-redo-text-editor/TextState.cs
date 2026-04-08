using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.undo_redo_text_editor
{
    internal class TextState
    {
        // Text details
        public string Content;

        // Pointer to next state (redo)
        public TextState Next;

        // Pointer to previous state (undo)
        public TextState Prev;

        // Constructor
        public TextState(string content)
        {
            Content = content;
            Next = null;
            Prev = null;
        }

    }
}
  