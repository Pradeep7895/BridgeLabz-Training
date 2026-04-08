using System;
using System.ComponentModel.Design;
class ClaculateGrade
{
    static void Main(string[] args)
    {
        //input marks
        Console.WriteLine("Enter marks of physics:");
        int physics = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks of chemistry:");
        int chemistry = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks of maths:");
        int maths = int.Parse(Console.ReadLine());

        //calculate total and percentage
        double average = (physics + chemistry + maths) / 3;

        string grade;
        string remarks;

        //determine grade and remarks based on percentage
        if(average >= 80)
        {
            grade= "A";
            remarks ="Level 4, above normalized standards";
        }
        else if(average >= 70)
        {
            grade= "B";
            remarks ="Level 3, at agency-normalized standards";        
        }
        else if(average >= 60)
        {
            grade= "C";
            remarks ="Level 2, below, but approaching agency-normalized standards";
        }
        else if(average >= 50)
        {
            grade= "D";
            remarks ="Level 1, well below agency-normalized standards";
        }
        else if(average >= 40)
        {
            grade= "E";
            remarks ="Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade= "R";
            remarks ="Remedial standards";
        }
        //output grade and remarks
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);

    }
}