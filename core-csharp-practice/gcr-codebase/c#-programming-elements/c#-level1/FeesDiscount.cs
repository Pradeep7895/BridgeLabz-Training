using System;
class FeesDiscount
{
    static void Main()
    {
        int fees= 125000;
        int discountPercent= 10;

        //Calculate discount
        int discount = (fees * discountPercent) / 100;

        //Calculate final fees after discount
        int finalFees = fees - discount;

        Console.WriteLine("The discount amount is INR " + discount + " and final discoumted fees is INR " + finalFees);

    }
}