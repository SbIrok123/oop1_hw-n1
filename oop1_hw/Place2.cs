using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_hw
{
    public class Place2
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Place2(string name, string description) { Name = name; Description = description; }
        public override string ToString()
        {
            return $"Place 2 - {Name}-\t {Description}";
        }
    }
}
