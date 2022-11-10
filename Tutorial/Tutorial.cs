// dotnet new console - set up the project configuration for a c# console application in VS Code

// Allows us to use classes from System namespace
using System;

/* namespace - used to organize code.
             - It's a container for classes and other namespaces */
namespace Variables 
{
    // class - container for data and methods   

    // Common class organization: 1 class holds methods and fields while the other class the MAIN method
    class Car
    {   
        // A variable declared directly in a class is called a 'field' or attribute
        public string color = "Blue";
    }

    class Tutorial
    {   // Method declaration
        // static - means the method belongs to Program class and it is not an object of Program class
        // void - means that the method does not have a return value
        // Default parameters - initialized using an equal sign. Also called an optional parameter
        static void MyFunc(string language = "C#")
        {
            Console.WriteLine("This is a method in C#");
        }

        // Method parameters
        static void MyMethod(string name, int age)
        {
            Console.WriteLine("My name is " + name + ". I am " + age + " years old.");
        }

        // Return values in methods
        static int MySum(int x, int y)
        {
            return x + y;
        }

        // Method Overloading - multiple methods having the same name with different parameters
        static int PlusMethod(int a, int b)
        {
            return a + b;
        }
        static double PlusMethod(double a, double b)
        {
            return a + b;
        }

        // MAIN FUNCTION
        static void Main(string[] args)
        {
            int number = 32;
            int x = 5, y = 9, z = 7;
            const float PI = 3.1457f;
            char letter = 'A';
            string name = "Derick";
            float amount = 43.32f;
            bool isWorking = true;
            double score = 43.245D;

            // Type casting
            int num = 9;
            double count = (double) num; // Explicit casting

            // Type Conversion - using Convert.To<data-type>
            double amount2 = Convert.ToDouble(amount);
            
            Console.WriteLine(number);
            Console.WriteLine(letter);
            Console.WriteLine(name);
            Console.WriteLine(amount);
            Console.WriteLine(isWorking);
            Console.WriteLine(PI);
            Console.WriteLine(x + y + z);
            Console.WriteLine(count);
            Console.WriteLine(score);

            // User Input
            Console.WriteLine("Enter your name: ");
            string thyName = Console.ReadLine();
            Console.WriteLine("Your name is " + thyName);

            Console.WriteLine("Enter your age: ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your are " + myAge + " years old.");

            // Math functions in C#
            Math.Max(5, 8);
            Math.Min(8, 7);
            Math.Sqrt(64);
            Math.Abs(-56);
            Math.Round(35.9);

            // String methods
            string crew = "Migos";
            string name2 = crew.ToUpper();
            string name3 = crew.ToLower();
            Console.WriteLine(crew.Length); // String length

            // String Concatenation
            string group = "Gotham";
            string combo = string.Concat(group, crew);
            string combo2 = crew + group;

            // String Interpolation - substitute values of variables into placeholders in a string
            string firstName = "Derick";
            string lastName = "Pambah";
            string fullName = $"My fullname is {firstName} {lastName}.";

            // Accessing strings
            string houseName = "Munger";
            char roomName = houseName[0];

            // Find the Index of a specific character
            int result = houseName.IndexOf("U");

            /* Substring - extract characters from a string, starting from the specified 
            character position/index, and returns a new string. Often used with IndexOf
            to get the specific character position */
            string userName = "Pambah Derick";
            int charPos = userName.IndexOf("D");
            string lName = userName.Substring(charPos);

            // IF ELSE
            int time = 20;
            if (time < 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time > 20)
            {
                Console.WriteLine("Good Evening");
            }
            else 
            {
                Console.WriteLine("Random time");
            }

            /* Ternary Operator - used to write simple if statement
               variable = (condition) ? expressionTrue : expressionFalse; */
            int date = 22;
            string results = (date < 20) ? "Buy Groceries" : "Pay rent";

            // Switch statement
            int day = 4;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the weekend");
                    break;
            }

            // While Loop & Do While loop
            // While
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do while
            int j = 1;

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 7);

            // For Loop - useful when you know the exact number of loops you're expected to make
            for (int r = 0; r < 9; r++)
            {
                Console.WriteLine(r);
            }

            /* Foreach Loop - used to exclusively loop through elements in an array
               foreach (type variableName in arrayName)
               {
                   code to be executed;
               } 
            */
            string[] cars = {"Volvo", "Mercedes", "Lambo", "Ferrari"};
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }

            // Arrays - used to store multiple values in a single variable
            // Ways of creating an array
            // 1. Create an array of 4 elements and initialize later
            string[] cars1 = new string[4]; 
            // 2. Create an array of 4 elements and add values right away
            string[] cars2 = new string [4] {"Lambo", "Ford", "Maserati", "Volkswagen"};
            // 3. Create an array of 4 elements without specifying the size
            string[] cars3 = new string [] {"Ducati", "Redbull", "Audi", "Toyota"};
            // 4. Create a 4 element array, omitting the size and 'new' keyword
            string[] cars4 = {"Nissan", "Bugatti", "McLaren", "Renault"}; 

            // PS: If you declare an array and initialize it later, you have to use the new keyword
            string[] vans;
            vans = new string[] {"Bentley", "BMW", "Range Rover"};

            // Accessing arrays
            Console.WriteLine(cars[2]);
            // Array length
            Console.WriteLine(cars.Length);
            // Change an element in an array
            cars[0] = "Volvo";
            // Array of type integer
            int[] marks = {88, 80, 92, 94, 99};

            /* Loop through an array - loop using for loop and use the Length property to specify
               how many times the loop should run */
            string[] cars6 = {"Jeep", "Jaguar", "Mazda", "Actros"};
            for (int b = 0; b < cars6.Length; b++)
            {
                Console.WriteLine(cars6[b]);
            }
            // PS: foreach loop can also be used to loop over an array
            string[] cars7 = {"Volvo", "Mercedes", "Lambo", "Ferrari"};
            foreach (string c in cars7)
            {
                Console.WriteLine(c);
            }

            // Sorting arrays - Using Sort()
            int[] myNums = {89, 90, 87, 69, 70};
            Array.Sort(myNums);
            foreach (int k in myNums)
            {
                Console.WriteLine(k);
            }
            // System.Linq namespace - contains the Min, Max, Sum , etc. functions

            // METHODS - also referred to as functions
            // Calling a method
            MyFunc();
            MyFunc();
            MyMethod("Dero", 22);
            int total = MySum(33, 89);

            // Named Arguments in methods - the order won't matter
            // Involves sending arguments with the key: value syntax
            MyMethod(age: 22, name: "Pambah");

            // Method overloading
            int output = PlusMethod(24, 43);
            double output2 = PlusMethod(34.34, 23.76);

            // CLASSES - OOP IN C#
            // class - template for objects
            // object - instance of a class
            // Create an object
            Car myObj = new Car();
            Console.WriteLine(myObj.color);

            // Class members - used to refer to fields and methods inside a class

            // Methods normally belong to a class and they define how an object of a class behaves

            // Constructors - Special method used to initialize objects
            /*  - Constructor name MUST match the class name and it should not have a return type
                - Constructor is called when the object is created 
                - All classes have constructors by default
                - If you don't explicitly create a constructor, then you won't be able to set initial values for fields
            */
            
            // ACCESS MODIFIERS
            /* public - code is accessible for all classes
               private (default) - code is only accessible within the same class
               protected - code is only accessible within the same class, or in a class that is inherited
               from that class 
               internal - code is only accessible from its own assembly but not from another assembly
               There's also: protected internal & private protected
            */

            // PROPERTIES - It's like a combination of a variable and a method
            /* - It has 2 methods: 'get' and 'set'
               - Can be used to access private access code
            */
            Person objj = new Person();
            objj.Name = "Keira";
            Console.WriteLine(objj.Name);

            // INHERITANCE (derived and base class) - use ':' 
            /* class Vehicle{} - parent class (base class)
               class Car : Vehicle{} - derived class (child class)
            */
            // Use the 'sealed' keyword to prevent a class from being inherited
            // e.g sealed class Program{}

            // POLYMORPHISM - means many forms. Occurs when we have many classes related to each other by inheritance
            // Inheritance inherits fields and methods from other classes. Polymorphism uses those methods to perform
            // different tasks. Thus, allowing us to perform a single action in different ways

            // ABSTRACTION - hiding certain details and only showing essential features to users
            // It is achieved through abstract classes or interfaces
            /* Abstract class - restricted class that cannot be used to create objects 
                              - to access it, it must be inherited from another class 
                              - can have both abstract and regular methods
               Abstract method - can only be used in an abstract class and does not have a body
                               - the body is provided by the derived class

               INTERFACE - A completely abstract class that can only contain abstract methods and properties
                         - Has an empty body.
                         - Can only contain methods and properties but not fields
                         - By default, members of an interface are abstract and public
            */

            // ENUMS - special class that represents a group of constants

            // FILES - 'File' class from 'System.IO' namespace helps us work with files
            // Examples of methods in the File class
            /* AppendText() - append text at the end of a file
               Copy() - copies a file
               Create() - creates or overwrites a file
               Delete() - deletes a file
               Exists() - test whether a file exists
               ReadAllText() - read the contents of a file
               Replace() - replace file contents with contents of another file
               WriteAllText() - create a new file and write the contents to it. If it exists, it'll be overwritten
            */

            // EXCEPTIONS - stop the program when an error occurs and generate an error message
            // try - catch block
            // try - define code to be tested for errors when a piece of code is being executed
            // catch - define a block of code to be executed if an error occurs in the try block
            // finally - lets you execute code after try-catch block regardless of the result
            
            // 'throw' keyword - allows you to create a custom error. It is used together with an exception class
            // Ex. of exception classes: ArithmeticException, FileNotFoundException, IndexOutOfRangeException,
            // TimeOutException

        }

        // Class members
        // Variables inside a class are called fields
        // Constructors
        class MyClass
            {
                string color = "green"; // Field
                int maxSpeed = 200; // Field
                public void fullThrottle() // Method
                {
                    Console.WriteLine("The car is going as fast as it can.");
                }

                public string model;
                public string shade;
                public int year;

                // constructor
                public MyClass(string modelName, string modelShade, int modelYear)
                {
                    model = modelName;
                    shade = modelShade;
                    year = modelYear;
                }

                static void Main(string[] args)
                {
                    MyClass obj = new MyClass("Astra", "Black", 2012);
                    // Calling a method - it must be public
                    obj.fullThrottle();
                    Console.WriteLine(obj.model +" "+ obj.shade +" "+ obj.year);

                    /* PS: a 'static' method can be accessed without creating an object of the class
                       while 'public' methods can only be accessed by objects 
                    */ 
                }
            }

            // Class to illustrate a property
            class Person
            {   
                // It is good practice to use same name for a private field and property, though start with capital letter
                private string name; // Field
                public string Name // Property
                {
                    get { return name; }
                    set { name = value; }
                }

                // Shorthand for the property implementation above
                // You don't have to define the field for the property
                /* public string Name
                   { get; set; }
                */
            }
    }
    
}
