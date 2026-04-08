using System;
class DividePens
{
    static void Main()
    {
        int totalPens=14;
        int students=3;

        //pens per student
        int pensPerStudent=totalPens/students;

        //remaining pens
        int remainingPens=totalPens%students;

        Console.WriteLine("The pen per student is " + pensPerStudent + " and the remaining pen not distributed is " + remainingPens);
    }
}