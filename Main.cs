//Main.cs

using Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Bird bird = new Bird();
        Dog dog = new Dog();

        animal.AnimalSound();
        bird.AnimalSound();
        dog.AnimalSound();

    }
}
