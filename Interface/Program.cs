using System;

namespace Interface
{   // The alternative way of setting up abstraction
    // It's always good practice to start interface names with a capital letter 'I' to identify them from classes
    // Upon the implementation of an interface, you must override all of its methods

    // Why interfaces:
    // security - hide certain details and only show important details of the object
    // Multiple interfaces - C# doesn't offer multiple inheritance. However, this can be achieved through interfaces
    // To implement multiple interfaces, separate them using commas
    interface IAnimal
    {
        void animalSound(); // Interface method: has no body
    } 

    // Pig "implements" IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: Wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myAnimal = new Pig();
            myAnimal.animalSound();
        }
    }
}