using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //explicit typing
            string variableName = "Hello";


            // infered typing
            var variableName2 = "Hello";

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine($"-----------------------------------------------------\n");

            Console.WriteLine("Hello World!");


            //Exercise 2

            //var r = 20;
            //var pi = Math.PI;

            //var areaOfCircle = pi * (r * r);


            //Console.WriteLine($" The area of a circle with radius of {r} is {areaOfCircle}");


            //Exercise 3
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = CalculateArea(radius);
            Console.WriteLine($" the GIVEN  area of circle is {areaOfCircle}  that has {radius} radius ");
            


            static double CalculateArea(double radius)
            {
                return Math.PI * (radius * radius);
               
               
            }

        }
    }
}
