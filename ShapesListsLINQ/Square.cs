namespace ShapesListsLINQ
{
    // Create a class Square that inherits Rectangle.
    // The constructor initializes the Side property.
    // Override and implement the Area() and Perimeter() methods.
    class Square : Rectangle
    {
        public double Side { get; set; }

        // parameterized constructor
        public Square(double _side) : base(_side, _side) => Side = _side;

        public override double Area() => base.Area();
        public override double Perimeter() => base.Perimeter();

    } // end of Square class
}
