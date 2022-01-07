/**
 *
 * @author Svetlana Komarova
 */

using System;

namespace ShapesListsLINQ
{
    // Create a class Triangle that also inherits Shape.
    // The constructor initializes the side A, side B and side C properties. 
    // Override and implement the Area() and Perimeter() methods.

    class Triangle : Shape
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }

        // parameterized constructor
        public Triangle(double _sideA, double _sideB, double _sideC)
        {
            Side_A = _sideA;
            Side_B = _sideB;
            Side_C = _sideC;
        }

        //Area = √[s(s-a)(s-b)(s-c)] - Heron's Formula, where s is the semi-perimeter
        public override double Area()
        {
            double s = Perimeter() / 2;

            return Math.Sqrt(s * (s - Side_A) * (s - Side_B) * (s - Side_C));
        }
        public override double Perimeter() => Side_A + Side_B + Side_C;

    } // end of Triangle class
}
