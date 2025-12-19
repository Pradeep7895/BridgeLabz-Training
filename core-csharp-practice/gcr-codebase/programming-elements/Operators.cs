using System; 

class Operators{
    static void Main(){
        
        // Variable Initialization
        
        int a = 10;
        int b = 5;

        
        // 1. Arithmetic Operators
        // +  -  *  /  %
        
        Console.WriteLine("---- Arithmetic Operators ----");
        Console.WriteLine("Addition: " + (a + b));        // 10 + 5 = 15
        Console.WriteLine("Subtraction: " + (a - b));     // 10 - 5 = 5
        Console.WriteLine("Multiplication: " + (a * b)); // 10 * 5 = 50
        Console.WriteLine("Division: " + (a / b));        // 10 / 5 = 2
        Console.WriteLine("Modulus: " + (a % b));         // 10 % 5 = 0

        
        // 2. Relational / Comparison Operators
        // ==  !=  >  <  >=  <=
        
        Console.WriteLine("\n---- Relational Operators ----");
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
        Console.WriteLine("a > b  : " + (a > b));
        Console.WriteLine("a < b  : " + (a < b));
        Console.WriteLine("a >= b : " + (a >= b));
        Console.WriteLine("a <= b : " + (a <= b));

        
        // 3. Logical Operators
        // &&  ||  !
        
        bool x = true;
        bool y = false;

        Console.WriteLine("\n---- Logical Operators ----");
        Console.WriteLine("x && y : " + (x && y)); // AND
        Console.WriteLine("x || y : " + (x || y)); // OR
        Console.WriteLine("!x     : " + (!x));     // NOT

        
        // 4. Assignment Operators
        // =  +=  -=  *=  /=  %=
        
        Console.WriteLine("\n---- Assignment Operators ----");
        int c = 10;
        c += 5;   // c = c + 5
        Console.WriteLine("c += 5 : " + c);

        c -= 3;   // c = c - 3
        Console.WriteLine("c -= 3 : " + c);

        c *= 2;   // c = c * 2
        Console.WriteLine("c *= 2 : " + c);

        c /= 4;   // c = c / 4
        Console.WriteLine("c /= 4 : " + c);

        c %= 3;   // c = c % 3
        Console.WriteLine("c %= 3 : " + c);

        
        // 5. Unary Operators
        // ++  --  +  -
        
        Console.WriteLine("\n---- Unary Operators ----");
        int d = 5;
        Console.WriteLine("d++ : " + (d++)); // Post-increment
        Console.WriteLine("++d : " + (++d)); // Pre-increment
        Console.WriteLine("d-- : " + (d--)); // Post-decrement
        Console.WriteLine("--d : " + (--d)); // Pre-decrement

        
        // 6. Ternary Operator
        // condition ? true : false
       
        Console.WriteLine("\n---- Ternary Operator ----");
        int max = (a > b) ? a : b;
        Console.WriteLine("Maximum value: " + max);

    }
}
