using System;

namespace Abstraction
{   
    abstract class Animal
    {
        public abstract void animalSound(); // abstract method
        public void sleep() // Regular method
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: Wee wee");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Pig myObj = new Pig();
            myObj.animalSound();
            myObj.sleep();
        }
    }
}