using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternSample.Models
{
    public class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Race { get; set; }
        public List<string> Owners { get; set; }
    }
}
