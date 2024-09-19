using oop1_hw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSpaces
{
    public class AllSevenPlaces
    {
        public Place1 place1;
        public Place2 place2;
        public Place3 place3;
        public Place4 place4;
        public Place5 place5;
        public Place6 place6;
        public Place7 place7;
        public AllSevenPlaces() { 
        place1 = new Place1("AAA", "Lorem");
        place2 = new Place2("AAA", "Lorem");
        place3 = new Place3("AAA", "Lorem");
        place4 = new Place4("AAA", "Lorem");
        place5 = new Place5("AAA", "Lorem");
        place6 = new Place6("AAA", "Lorem");
        place7 = new Place7("AAA", "Lorem");
        }
        public void ShowInfo()
        {
            Console.WriteLine(place1);
            Console.WriteLine(place2);
            Console.WriteLine(place3);
            Console.WriteLine(place4);
            Console.WriteLine(place5);
            Console.WriteLine(place6);
            Console.WriteLine(place7);
        } 
    }
}
