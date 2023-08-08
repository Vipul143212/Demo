using Demo.Interfaces;

namespace Demo
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();
    }
    class Cat : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Move()
        {
            Console.WriteLine("Cat is climbing.");
        }
    }

    public class Dog : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void Move()
        {
            Console.WriteLine("Dog is moving.");
        }
    }
    public class AnimalMainMethod
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog { Name = "Tommy", Age = 5 },
                new Cat { Name = "Jelly", Age = 2 }
            };
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                animal.MakeSound();
            }
        }
    }
}
