using System;

namespace Enums
{
    // Enums can also be declared inside classes
    enum Level
    {
        Low,
        Medium,
        High
    }

    // Enum Values
    enum Months
    {
        January, // 0
        February, // 1
        March=6,
        April, // 7
        May, // 8
        June // 9
    }

    // Enum in a switch statement
    enum Standards
    {
        Low,
        Medium,
        High
    }


    class Program
    {
        static void Main(string[] args)
        {
            Level myLevel = Level.High;
            Console.WriteLine(myLevel);

            // Enum Values
            int myNum = (int) Months.April;
            Console.WriteLine(myNum);

            // Enums in switch statement
            Standards std = Standards.Low;
            switch(std)
            {
                case Standards.Low:
                    Console.WriteLine("Low Standard");
                    break;
                case Standards.Medium:
                    Console.WriteLine("Medium standard");
                    break;
                case Standards.High:
                    Console.WriteLine("High Standard");
                    break;
            }
        }
    }
}