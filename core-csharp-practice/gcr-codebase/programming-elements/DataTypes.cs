using System;
class DataTypes{
	static void Main(String[] args){
		//Different types of primitive operators
		byte b = 2;
        short s = 200;
        int i = 1000;
        long l = 100000L;

        float f = 12.5f;
        double d = 99.99;

        char c = 'A';
        bool flag = true;
		
		//Display primitive data types
		Console.WriteLine("---- Primitive Data Types ----");
        Console.WriteLine("Byte: " + b);
		Console.WriteLine("short: " + s);
		Console.WriteLine("int: " + i);
		Console.WriteLine("long: " + l);
		Console.WriteLine("float: " + f);
		Console.WriteLine("double: " + d);
		Console.WriteLine("char: " + c);
		Console.WriteLine("Boolean: " + flag);
		
		
		// Implicit Type Casting (Widening)
        // Smaller type → Larger type
		
		// int is automatically converted to double
        int numInt = 50;
        double numDouble = numInt; 
		
		// char converted to its ASCII value
		char ch = 'B';
        int asciiValue = ch;         

        Console.WriteLine("\n---- Implicit Type Casting ----");
        Console.WriteLine("Int to Double: " + numDouble);
        Console.WriteLine("Char to Int (ASCII): " + asciiValue);
		
		// int to float using ToString()
		int num1=50;
		//ToString() converts the integer into text (string).
		string str=num1.ToString();
		//float.Parse() converts the string into a float.
		float res= float.Parse(str);
		//Prints the float value
        //"0.0" ensures one decimal place is shown
        //Output becomes 50.0 instead of just 50
		Console.WriteLine("Float value is:"+res.ToString("0.0"));
		
		
		// Explicit Type Casting (Narrowing)
        // Larger type → Smaller type
		
		// Decimal part is lost
		double price = 123.45;
        int priceInt = (int)price;   
		
		
        // Overflow occurs
        int bigNumber = 130;
        byte smallByte = (byte)bigNumber; 
        
		// ASCII value converted to character
        int ascii = 67;
        char character = (char)ascii; 

        Console.WriteLine("\n---- Explicit Type Casting ----");
        Console.WriteLine("Double to Int: " + priceInt);
        Console.WriteLine("Int to Byte: " + smallByte);
        Console.WriteLine("Int to Char: " + character);
	}
}