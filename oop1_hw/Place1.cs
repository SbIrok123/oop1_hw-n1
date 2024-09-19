using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_hw
{
    public class Place1
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Place1(string name,string description) { Name = name;Description = description;}
        public override string ToString()
        {
            return $"Place 1 - {Name}-\t {Description}";
        }
    }
}
