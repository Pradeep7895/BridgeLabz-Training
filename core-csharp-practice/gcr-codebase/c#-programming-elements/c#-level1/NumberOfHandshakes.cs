using System;

class Handshakes
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculate the number of handshakes using the formula n(n-1)/2

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("The total number of handshakes among " + numberOfStudents + " students is: " + handshakes);
    }
}
