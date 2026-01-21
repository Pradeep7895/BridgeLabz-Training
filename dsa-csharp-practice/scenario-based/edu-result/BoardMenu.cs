using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class BoardMenu
    {
        IBoard board = new BoardUtility();
        int boardid = 0;
        public void Start()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n===RESULT FUNCTION===");
                Console.WriteLine("1. Add District");
                Console.WriteLine("2. Add Student in a District");
                Console.WriteLine("3. Merge the result of all the district");
                Console.WriteLine("4. Sort for the top ten");
                Console.WriteLine("5. Display the Top Ten");

                Console.Write("Entre choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<StudentMarks> d = new List<StudentMarks>();
                        board.AddDistrict(new District(boardid++, d));
                        Console.WriteLine("District Added.");
                        break;
                    case 2:
                        Console.WriteLine("Enter the District Id:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("1.enter name\n2.enter marks:");
                        string name = Console.ReadLine();
                        double marks = Convert.ToDouble(Console.ReadLine());

                        board.AddDistrictStudents(id, new StudentMarks(name, marks));
                        break;
                    case 3:
                        board.MergeDistrict();
                        break;
                    case 4:
                        board.MergeSort();
                        break;
                    case 5:
                        board.DisplayTopTen();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
