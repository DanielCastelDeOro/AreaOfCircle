using System;

namespace AreaOfCircle
{
    class Program
    {
        //Methods need a body enclosed in {}
        //That's where the work is done/math is calculated/magic happens
        public static double CalculateArea(double radius)
        {
            //moved below line from Main method into this CalculateArea method so it can calculate area
            return Math.PI * (radius * radius);
        }

        static void Main(string[] args)
        {
            //Changed question below to ask for radius from user
            Console.WriteLine("What is the radius of the circle?");

            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = CalculateArea(radius);
            
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");

            
        }
        
            
        
    }
}
