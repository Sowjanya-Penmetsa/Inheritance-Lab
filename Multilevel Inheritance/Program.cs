using System;

namespace Multilevel_Inheritance
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

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();


        }
    }
}
