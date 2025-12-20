using System;
using System.IO.Compression;
class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1= double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2= double.Parse(Console.ReadLine());

        //addition
        double addition= num1+num2;
        //subtraction
        double subtraction= num1-num2;
        //multiplication
        double multiplication= num1*num2;
        //division
        double division= num1/num2;

        Console.WriteLine("The addition,subtraction,multiplication and division value of 2 numbers" + num1 + " and " + num2 + " is : " + addition + " , " + subtraction + " , " + multiplication + " and " + division);

    }
}