using System;

namespace AreaOfCircle
{
    class Program
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of the circle?");

            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = CalculateArea(radius);
            
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");

            
        }
        
            
        
    }
}
