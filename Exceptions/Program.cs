using System;

try
{
    int[] numbers = {3, 4, 5, 6};
    Console.WriteLine(numbers[10]);
    // Shorthand
    // Console.WriteLine((new int[] { 3, 4, 5, 6 })[10]);
}
catch(Exception e)
{
    Console.WriteLine(e.Message); // System-generated error message
    // Custom message - Console.WriteLine("Something went wrong");
}
finally 
{
    Console.WriteLine("The 'try-catch' is finished");
}

// throw keyword

class program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else 
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

    static void Main(string[] args)
    {
        CheckAge(14);
    }
}