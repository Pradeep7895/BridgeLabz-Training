using System;
class TotalPrice
{
    static void Main()
    {
        Console.Write("Enter the price of the item: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter the quantity of the item: ");
        int quantity = int.Parse(Console.ReadLine());
        
        //total price calculation
        double totalPrice = price * quantity;
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and price per item is INR " + price);
    }
}