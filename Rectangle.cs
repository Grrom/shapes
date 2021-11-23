using System;

namespace shapes
{
    class Rectangle : Shape
    {
        double height, width;

        public Rectangle(double _height, double _width)
        {
            height = _height;
            width = _width;
        }
    }
}
