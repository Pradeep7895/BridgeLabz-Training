using System;
class StudentFee
{
    static void Main()
    {
        Console.Write("Enter the student fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the discount percentage: ");
        double discountAmount  = Convert.ToDouble(Console.ReadLine());

        //claculate discount
        double discount = fee * discountAmount / 100;
        //fees after discount
        double finalFee = fee - discount;

        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fees is INR " + finalFee);
        
    }
}