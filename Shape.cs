using System;
using System.Collections.Generic;
using System.Text;

namespace shapes
{
    public class Shape
    {
        string color;
        int x, y;
        public Shape()
        {
            Console.WriteLine("Creating a " + this.GetType());
        }

        public Shape Clone()
        {
            Console.WriteLine(this.GetType() + " is Being Cloned");
            return this;
        }
    }
}
