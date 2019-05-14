using BuilderPatternSample.Models;
using System.Collections.Generic;

namespace BuilderPatternSample
{
    public class CatsBuilder : IPetsBuilder<Cat>
    {
        private Cat _cat;
        public CatsBuilder()
        {
            _cat = new Cat();
        }
        public IPetsBuilder<Cat> AddNames()
        {
            _cat.Name = "Cat 1";
            return this;
        }

        public IPetsBuilder<Cat> AddOwners()
        {
            _cat.Owners = new List<string> {"Cat Owner 1", "Cat Owner 2" };
            return this;
        }

        public Cat Build()
        {
            return _cat;
        }
    }
}
