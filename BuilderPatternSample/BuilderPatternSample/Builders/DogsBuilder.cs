using BuilderPatternSample.Models;
using System.Collections.Generic;

namespace BuilderPatternSample
{
    public class DogsBuilder : IPetsBuilder<Dog>
    {
        private Dog _dog;
        public DogsBuilder()
        {
            _dog = new Dog();
        }

        public IPetsBuilder<Dog> AddNames()
        {
            _dog.Name = "Perro1";
            return this;
        }

        public IPetsBuilder<Dog> AddOwners()
        {
            _dog.Owners = new List<string> { "Dog Owner 1", "Dow Owner 2" };
            return this;
        }

        public Dog Build()
        {
            return _dog;
        }
    }
}
