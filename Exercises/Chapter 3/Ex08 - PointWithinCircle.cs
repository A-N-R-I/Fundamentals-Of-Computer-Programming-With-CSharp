using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter3
    {
        public static class Ex08_PointWithinCircle
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter x and y: ");
                string[] input = Console.ReadLine().Split();

                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);

                double radius = 5;

                // Circle is centered around origin {0, 0}, so we don't need to calculate any offsets
                // Use Pythagoras' theorem to calculate the distance of the given point from the origin
                double distance = Math.Sqrt(x * x + y * y);
                bool isWithinCircle = distance <= radius;

                Console.WriteLine($"\nradius: {radius}\npoint: ({x}, {y})\ndistance from origin (0, 0): {distance:0.000}\nis within circle? {isWithinCircle}");
            }
        }
    }
}