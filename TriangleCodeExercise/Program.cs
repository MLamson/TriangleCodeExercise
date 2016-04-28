using System;

namespace TriangleCodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // I did google to find syntax for ToInt32
            Console.WriteLine("Enter side 1 length");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 2 length");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 3 length");
            int side3 = Convert.ToInt32(Console.ReadLine());

            string result = isTriangle(side1, side2, side3);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string isTriangle(int side1, int side2, int side3)
        {
            string result;

            if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
            {
                result = "is not a triangle";
            }
            else
            {
                if (side1 == side2 && side2 == side3)
                {
                    result = "is an Equilateral triangle";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    result = "is an Isosceles triangle";
                }
                else
                {
                    result = "is a Scalene triangle";
                }
            }
            return result;
        }
    }
}


