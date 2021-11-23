using System;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");

            Console.WriteLine("");

            Shape circle = new Circle(20);
            Shape rectangle = new Rectangle(20, 30);

            Console.WriteLine("");

            Console.WriteLine("Start Cloning");
            Shape circleClone = circle.Clone();
            Shape rectangleClone = rectangle.Clone();

        }
    }
}
