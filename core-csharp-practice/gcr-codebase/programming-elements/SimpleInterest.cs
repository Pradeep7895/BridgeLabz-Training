class SimpleInterest
{
    static void Main(string[] args)
    {
        double principal = 1000.0; 
        double rate = 5.0;         
        double time = 3.0;         

        double simpleInterest = (principal * rate * time) / 100;
        System.Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}