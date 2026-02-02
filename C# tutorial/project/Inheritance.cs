using System;

namespace Project
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing");
        }
    }

    class Inheritance
    {
        public static void Run(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}