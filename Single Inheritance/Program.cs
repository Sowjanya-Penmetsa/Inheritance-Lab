using System;

namespace Single_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Eat();
            Console.WriteLine();

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.WriteLine();
        }
    }
}
