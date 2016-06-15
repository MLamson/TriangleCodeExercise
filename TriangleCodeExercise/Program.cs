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

                string result = IsTriangle(side1, side2, side3);

                Console.WriteLine(result);
                Console.ReadLine();
            }   


            internal static string IsTriangle(int triangleSide1, int triangleSide2, int triangleSide3)
            {
                string result = "";

            if (triangleSide1 == triangleSide2 && triangleSide2 == triangleSide3)
            {
                result = "Is an equilateral triangle";
            }
            else if (triangleSide1 + triangleSide2 > triangleSide3 && triangleSide1 + triangleSide3 > triangleSide2 &&
               triangleSide2 + triangleSide3 > triangleSide1)
            {
                if (triangleSide1 == triangleSide2 || triangleSide1 == triangleSide3 || triangleSide2 == triangleSide3)
                {
                    result = "Is an isosceles triangle";
                }
                else
                {
                    result = "Is a scalene triangle";
                }  
            }
            else
            {
                result = "Is not a triangle";
            }
            return result;
        }
    }
}

