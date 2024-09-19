using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_hw
{
    public class Place7
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Place7(string name, string description) { Name = name; Description = description; }
        public override string ToString()
        {
            return $"Place 7 - {Name}-\t {Description}";
        }
    }
}
