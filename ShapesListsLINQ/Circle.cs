using System;

/**
 *
 * @author Svetlana Komarova
 */

namespace ShapesListsLINQ
{
    // Create a class Circle that inherits from Shape.
    // The constructor initializes the Radius property.
    // Override and implement the Area() and Perimeter() methods.
    class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(double _radius) => Radius = _radius;

        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;

    } // end of Circle class
}
