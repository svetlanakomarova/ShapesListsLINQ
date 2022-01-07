/**
 *
 * @author Svetlana Komarova
 */

namespace ShapesListsLINQ
{
    // Create a class Rectangle that also inherits Shape.
    // The constructor initializes the Length and Width properties. 
    // Override and implement the Area() and Perimeter() methods.
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // parameterized constructor
        public Rectangle(double _length, double _width)
        {
            Length = _length;
            Width = _width;
        }

        public override double Area() => Length * Width;
        public override double Perimeter() => 2 * (Length + Width);

    } // end of Rectangle class
}
