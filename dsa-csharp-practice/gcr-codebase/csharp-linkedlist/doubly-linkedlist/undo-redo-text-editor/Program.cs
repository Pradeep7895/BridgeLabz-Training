using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.doubly_linkedlist.undo_redo_text_editor
{
    internal class Program
    {
        static void Main()
        {
            // Create text editor
            TextEditor editor = new TextEditor();

            // Add text states
            editor.AddState("Hello");
            editor.DisplayCurrentText();

            editor.AddState("Hello World");
            editor.DisplayCurrentText();

            editor.AddState("Hello World!");
            editor.DisplayCurrentText();

            // Undo operations
            Console.WriteLine("\nUndo:");
            editor.Undo();
            editor.DisplayCurrentText();

            Console.WriteLine("\nUndo:");
            editor.Undo();
            editor.DisplayCurrentText();

            // Redo operation
            Console.WriteLine("\nRedo:");
            editor.Redo();
            editor.DisplayCurrentText();

            // Add new text (clears redo history)
            Console.WriteLine("\nAdd New Text:");
            editor.AddState("Hello C#");
            editor.DisplayCurrentText();
        }
    }
}

    
