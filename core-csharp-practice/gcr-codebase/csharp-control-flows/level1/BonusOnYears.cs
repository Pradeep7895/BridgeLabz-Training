using System;

class BonusOnYears
{
    static void Main()
    {

        //input for salary
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        
        //input for years of service
        Console.Write("Enter years of service: ");
        int years = int.Parse(Console.ReadLine());


        //check if years of service is greater than 5
        if(years > 5)
        {
            //calculate bonus as 5% of salary
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus = " + bonus);
        }
    }
}
