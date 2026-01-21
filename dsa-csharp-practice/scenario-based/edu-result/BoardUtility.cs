using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class BoardUtility:IBoard
    {
        List<District> district = new List<District>();
        List<StudentMarks> sortedList = new List<StudentMarks>();
        public void AddDistrict(District d1) 
        {
            district.Add(d1);
        }
        public void AddDistrictStudents(int id,StudentMarks student)
        {
            foreach(District d in district)
            {
                if(d.districtId == id)
                {
                    d.districtStudents.Add(student);
                    Console.WriteLine("Student Added.");
                    return;
                }
            }
        }
        public void MergeDistrict()
        {
            sortedList.Clear();
            foreach (District d in district)
            {
                District districts = new District(d.districtId, d.districtStudents);
                districts.Sort();
                sortedList.AddRange(districts.districtStudents);
            }
            Console.WriteLine("District result merged to be sorted.");
        }
        public void MergeSort()
        {
            MergeSort(sortedList, 0, sortedList.Count-1);
            Console.WriteLine("Sorted the list of student ");
        }
        public void MergeSort(List<StudentMarks>SortedList, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(sortedList, left, mid);
                MergeSort(sortedList, mid + 1, right);
                SortingList(sortedList, left, mid, right);
            }
        }

        private void SortingList(List<StudentMarks> sortedList, int left, int mid , int right)
        {
            StudentMarks[] leftArray = sortedList.GetRange(left, mid-left + 1).ToArray();
            StudentMarks[] rightArray = sortedList.GetRange(mid+1, right -mid).ToArray();

            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i].GetMarks() >= rightArray[j].GetMarks())
                {
                    sortedList[k++]=leftArray[i++];
                }
                else
                {
                    sortedList[k++]=rightArray[j++];
                }
            }
            while (i < leftArray.Length) sortedList[k++] = leftArray[i++];
            while (j < rightArray.Length) sortedList[k++] = rightArray[j++];

        }

        public void DisplayTopTen()
        {
            if (sortedList.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(sortedList[i]);
                }
            }
            else
            {
                for (int i = 0; i <sortedList.Count; i++)
                {
                    Console.WriteLine(sortedList[i]);
                }
            }
               
        }
    }
}
