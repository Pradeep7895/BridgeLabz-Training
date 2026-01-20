using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_number
{
    internal class RadixSorting
    {
        public void Sort(AadharRecord[] records)
        {
            long max = GetMax(records);

            for (long exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(records, exp);
            }
        }

        private long GetMax(AadharRecord[] records)
        {
            long max = records[0].GetNumber();
            foreach (var r in records)
                if (r.GetNumber() > max) max = r.GetNumber();
            return max;
        }

        // Stable Counting Sort
        private void CountingSort(AadharRecord[] records, long exp)
        {
            int n = records.Length;
            AadharRecord[] output = new AadharRecord[n];
            int[] count = new int[10];

            foreach (var r in records)
            {
                int digit = (int)((r.GetNumber() / exp) % 10);
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)((records[i].GetNumber() / exp) % 10);
                output[count[digit] - 1] = records[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
                records[i] = output[i];
        }

    }
}
  