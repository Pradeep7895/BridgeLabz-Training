using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.list_interface
{
    internal class RotateElements
    {
        static void RotateLeft(List<int> list , int k)
        {
            int n = list.Count;
            k = k % n;

            List<int> temp = new List<int>();

            //store first k elements
            for(int i=0; i < k; i++)
            {
                temp.Add(list[i]);
            }
            //shift remaining elements
            for(int i = k; i < n; i++)
            {
                list[i-k] = list[i];
            }
            //copy temp to end
            for(int i = 0; i < temp.Count; i++)
            {
                list[n-k+i]= temp[i];
            }
        }
        static void Main()
        {
            List<int> list = new List<int> { 10, 20, 30, 40, 50 };
            int k = 2;

            RotateLeft(list, k);

            foreach(int item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
