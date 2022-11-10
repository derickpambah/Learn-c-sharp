using System;

namespace Polymorphism
{   
    // If the base class has a method with the same name as the child class, then the child class method is overridden
    // Use the keyword 'virtual' in the base class method and keyword 'override' in the child class method to 
    // override the base class method
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound() 
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object
            
            Pig mip = new Pig();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            mip.animalSound();
        }
    }
}