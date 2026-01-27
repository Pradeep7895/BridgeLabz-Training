using System.Collections.Generic;

namespace CoreApp
{
    public class ListManager
    {
        // Add an element to the list
        public void AddElement(List<int> list, int element)
        {
            list.Add(element);
        }

        // Remove an element from the list
        public void RemoveElement(List<int> list, int element)
        {
            list.Remove(element);
        }

        // Return the size of the list
        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}
