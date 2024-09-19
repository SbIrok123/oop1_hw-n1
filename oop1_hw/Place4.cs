using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_hw
{
    public class Place4
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Place4(string name, string description) { Name = name; Description = description; }
        public override string ToString()
        {
            return $"Place 4 - {Name}-\t {Description}";
        }
    }
}
