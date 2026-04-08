using System;

class CalculatorUsingSwitch
{
    static void Main()
    {

        //enter first number
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        //enter second number
        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        //enter operator
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        //perform operation based on operator using switch case
        switch(op)
        {
            //addition
            case "+":
                Console.WriteLine("Result = " + (first + second));
                break;
            
            //subtraction
            case "-":
                Console.WriteLine("Result = " + (first - second));
                break;
            
            //multiplication
            case "*":
                Console.WriteLine("Result = " + (first * second));
                break;
            
            //division
            case "/":
                if(second != 0)
                    Console.WriteLine("Result = " + (first / second));
                else
                    Console.WriteLine("Division by zero not allowed");
                break;

            //invalid operator
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
