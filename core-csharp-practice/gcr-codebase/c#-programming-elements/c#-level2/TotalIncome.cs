using System;

class TotalIncome
{
    static void Main()
    {
        //user input for salary and bonus
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter bonus: ");
        double bonus = double.Parse(Console.ReadLine());
        //total income calculation
        double income = salary + bonus;

        Console.WriteLine("The salary is INR " + salary + " and the bonus is INR " + bonus + " Hence total income is INR " + income);
    }
}
