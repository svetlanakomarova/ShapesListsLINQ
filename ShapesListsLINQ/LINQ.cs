using System;
using System.Linq;

namespace ShapesListsLINQ
{
    class LINQ
    {
        public void DivisibleByTwo()
        {
            //create an integer array, initialized with the values 
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var numDivisible = from num in numbers
                                where num % 2 == 0
                                select num;

            Console.Write($"\nDivisibleByTwo Results:");
            foreach (var item in numDivisible)
            {
                Console.Write($" {item}");
            }

        } // end of DivisibleByTwo

        public void NumbersInRan()
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            // Alternative syntax
            // int[] numbers = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var numSorted = from num in numbers
                            where num > 0  && num < 12
                            orderby num descending
                            select num;

            Console.Write($"\nNumbersInRan Results:");
            foreach (var item in numSorted)
            {
                Console.Write($" {item}");
            }
            
        } // end of NumbersInRan

        public void CityInformation()
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                                "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};

            // display list of cities

            var city = from value in cities
                      select value;
            Console.Write("\nThe cities are :");

            for (int i = 0; i < city.Count(); i++)
            {
                if (i == city.Count() - 1)
                {
                    // print last element without comma
                    Console.Write($" {city.ElementAt(i)}");
                }
                else
                {
                    Console.Write($" {city.ElementAt(i)},");
                }
            }

            Console.Write("\nInput starting character for the city: ");
            string start = Console.ReadLine();
            Console.Write("Input ending character for the city: ");
            string end = Console.ReadLine();

            Console.WriteLine($"City(s) starting with {start} or ending with {end}:");

            // extract all city names that start with the starting character
            // or ends with the ending character
            
                var filtered = from name in cities
                               let uppercaseString = name.ToUpper()
                               where uppercaseString.StartsWith(start.ToUpper()) || uppercaseString.EndsWith(end.ToUpper())
                               select uppercaseString;
 
            if (!filtered.Any()) 
            { 
                Console.WriteLine("No city found."); 
            }
            else
            {
                foreach (var f in filtered)
                {
                    Console.WriteLine(f);
                }
            }

        }// end of CityInformation

    } // end of class
}
