using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD4
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }
}
