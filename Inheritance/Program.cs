using System;

namespace Inheritance
{
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut Tuut");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.honk();
            Console.WriteLine(myObj.brand +" "+ myObj.modelName);
        }
    }
}

