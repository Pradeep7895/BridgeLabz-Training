using System;
class EligibleForVote
{
    static void Main(string[] args)
    {
        //Enter age of the person
        Console.WriteLine("Enter age of the person:");
        int age = int.Parse(Console.ReadLine());

        //Check if the person is eligible to vote
        if (age >= 18)
        {
            Console.WriteLine("The person's age is " + age + " and can vote");

        }
        else
        {
            Console.WriteLine("The person's age is " + age + "and cannot vote");
        }
    }
}