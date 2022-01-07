/*
  Name: Svetlana Komarova
  Student Number: 991612772
  Assignment: Assignment 1

  PROG32356 .Net Technologies using C#
*/
using System;

namespace ShapesListsLINQ
{
    class Program
    {
        public static char selectShape()
        {
            Console.WriteLine("\nPlease select shape to process or [Q]uit:\n" +
                                "[C]ircle\n[R]ectangle\n[S]quare\n[T]riangle");
             return Console.ReadLine().ToUpper().ToCharArray()[0];     
        }

        public static char selectOutput()
        {
            Console.WriteLine("Please select output:\n" +
                            "[A]rea\n[P]erimeter\n[B]oth");
             return Console.ReadLine().ToUpper().ToCharArray()[0];
        }

        public static void calculateShape(Shape _shape)
        {
            switch (selectOutput())
            {
                case 'A':
                    Console.WriteLine("Area: " + _shape.Area().ToString("#.##"));
                    break;
                case 'P':
                    Console.WriteLine("Perimeter: " + _shape.Perimeter().ToString("#.##"));
                    break;
                case 'B':
                    Console.WriteLine("Area: " + _shape.Area().ToString("#.##"));
                    Console.WriteLine("Perimeter: " + _shape.Perimeter().ToString("#.##"));
                    break;
            }
        } 

        static void Main(string[] args)
        {
            //Part A.
            Console.Write("Part A\n------");

            bool doCalculation = true;

            do
            {               
                switch (selectShape())
                {
                    case 'C':
                        Console.Write("\nPlease enter circle radius: ");
                        double c = Double.Parse(Console.ReadLine());

                        // create and initialize new Circle object
                        Circle circle = new Circle(c);
                        calculateShape(circle);
                        break;

                    case 'R':
                        Console.Write("\nPlease enter rectangle side a: ");
                        double a = Double.Parse(Console.ReadLine());
                        Console.Write("Please enter rectangle side b: ");
                        double b = Double.Parse(Console.ReadLine());

                        // create and initialize new Rectangle object
                        Rectangle rec = new Rectangle(a, b);
                        calculateShape(rec);
                        break;

                    case 'S':
                        Console.Write("\nPlease enter square side: ");
                        a = Double.Parse(Console.ReadLine());

                        // create and initialize new Square object
                        Square sq = new Square(a);
                        calculateShape(sq);
                        break;

                    case 'T':
                        Console.Write("\nPlease enter triangle side a: ");
                        a = Double.Parse(Console.ReadLine());
                        Console.Write("Please enter triangle side b: ");
                        b = Double.Parse(Console.ReadLine());
                        Console.Write("Please en; triangle side c: ");
                        c = Double.Parse(Console.ReadLine());

                        // create and initialize new Triangle object
                        Triangle t = new Triangle(a, b, c);
                        calculateShape(t);
                        break;

                    default:
                        // quit calculation
                        doCalculation = false;
                        break;
                } // end of switch

            } while (doCalculation);

            //Part B.
            Console.Write("\nPart B\n------");

            LINQ l = new LINQ();
            l.DivisibleByTwo();
            l.NumbersInRan();
            l.CityInformation();

            Lists list = new Lists();
            list.displayStudent_AVG();
            list.displaySubject_AVG();
            list.displayStudent_High_Low_AVG();
            list.displaySubject_High_Low_forStudent();

        } // end of main
    }
}
