using System.Collections.Generic;

namespace BuilderPatternSample.Models
{
    public class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Race { get; set; }
        public string Color { get; set; }
        public List<string> Owners { get; set; }
    }
}
