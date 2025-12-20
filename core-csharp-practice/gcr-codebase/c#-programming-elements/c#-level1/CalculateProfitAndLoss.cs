using System;
class CalculateProfitAndLoss
{
    static void Main()
    {
        int costPrice = 1500;
        int sellingPrice = 2000;

        //Profit
        int profit= sellingPrice - costPrice;

        //profit percentage
        double profitPercent = (double)profit/costPrice*100;

        Console.WriteLine("The Cost Price is INR " + costPrice + "and Selling price is INR "+ sellingPrice);
        Console.WriteLine("The profit is INR " + profit + "and the Profit Percentage is " + profitPercent + "%");
    }
}