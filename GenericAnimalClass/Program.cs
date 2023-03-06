using System;

namespace GenericAnimalClass
{
    class Program
    {
        public class Animal<T>
        {
            public T data;

            public Animal(T data)
            {
                this.data = data;
            }

            public T getAnimal()
            {
                return data;
            }
        }
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("pangolin");
            Animal<string> animalHabitat = new Animal<string>("forests and savannahs");
            Animal<bool> endangered = new Animal<bool>(true);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan= new Animal<int>(5);

            Console.WriteLine("Species info:");
            Console.WriteLine($"Name: {animalName.getAnimal()}");
            Console.WriteLine($"Habitat: {animalHabitat.getAnimal()}");
            Console.WriteLine($"Endangered: {endangered.getAnimal()}");
            Console.WriteLine($"Extinct: {extinct.getAnimal()}");
            Console.WriteLine($"Average lifespan: {averageLifespan.getAnimal()}");
        }
    }
}