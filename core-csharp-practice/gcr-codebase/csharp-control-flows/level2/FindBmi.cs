using System;
class FindBmi
{
    static void Main(string[] args)
    {
        //Enter weight in kilograms
        Console.WriteLine("Enter weight in kilograms:");
        double weight = double.Parse(Console.ReadLine());

        //Enter height in meters
        Console.WriteLine("Enter height in meters:");
        double height = double.Parse(Console.ReadLine());

        //Calculate BMI
        double bmi = weight / (height * height);

        //Determine BMI category
        if(bmi <= 18.4)
            Console.WriteLine("Underweight");
        else if(bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("Normal weight");
        else if(bmi >= 25 && bmi <= 39.9)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}