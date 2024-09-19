using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_hw
{
    public class Place3
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Place3(string name, string description) { Name = name; Description = description; }
        public override string ToString()
        {
            return $"Place 3 - {Name}-\t {Description}";
        }
    }
}
