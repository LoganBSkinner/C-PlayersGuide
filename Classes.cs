//Classes.cs

using System;
using System.IO.Pipes;

namespace Classes
{
    
    public interface IAnimal
    {
        void AnimalSound();
    }
    
    public class Animal : IAnimal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal sound goes here");
        }
    }

    public class Bird : Animal, IAnimal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Chirp!");
        }
    }
    public class Dog : Animal, IAnimal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    public class Cat : Animal, IAnimal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Meow!");
        }
    }


}