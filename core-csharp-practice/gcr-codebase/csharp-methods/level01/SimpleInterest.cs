using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class SimpleInterest
    {
        //method to calculate simple interest
        static double SimpleInterestCal(double principle, double rate , double time)
        {
            return (principle * rate * time) / 100;
        }
        static void Main()
        {
            // Take principal input
            Console.Write("Enter Principal: ");
            double principal = double.Parse(Console.ReadLine());

            // Take rate input
            Console.Write("Enter Rate of Interest: ");
            double rate = double.Parse(Console.ReadLine());

            // Take time input
            Console.Write("Enter Time: ");
            double time = double.Parse(Console.ReadLine());

            //method call
            double si = SimpleInterestCal(principal, rate, time);

            //Display result
            Console.WriteLine("The simple interest is " + si + " for principal " + principal + " , Rate of interest " + rate + " and Time " + time);
        }
    }
}
