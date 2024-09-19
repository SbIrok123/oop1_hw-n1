using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_hw
{
    public class Place6
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Place6(string name, string description) { Name = name; Description = description; }
        public override string ToString()
        {
            return $"Place 6 - {Name}-\t {Description}";
        }
    }
}
