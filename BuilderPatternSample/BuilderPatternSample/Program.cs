using System;

namespace BuilderPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogBuilder = new DogsBuilder();
            dogBuilder.AddNames().AddOwners();
            var dog = dogBuilder.Build();


            var catBuilder = new CatsBuilder();
            catBuilder.AddNames().AddOwners();
            var cat = catBuilder.Build();

            Console.WriteLine("Hello World!");

            Console.WriteLine(cat.Name);
            foreach (var item in cat.Owners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(dog.Name);
            foreach (var item in dog.Owners)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
