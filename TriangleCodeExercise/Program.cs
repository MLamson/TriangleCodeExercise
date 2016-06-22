using System;

namespace TriangleCodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInputAndReturnResult();
        }   
        internal static string IsTriangle(int triangleSide1, int triangleSide2, int triangleSide3)
        {
            if (!(ValidTriangle(triangleSide1, triangleSide2, triangleSide3)))
            {
                return "Is not a triangle";
            }
            if (AllSidesEqual(triangleSide1, triangleSide2, triangleSide3))
            {
                return "Is an equilateral triangle";
            }
            if (TwoSidesEqual(triangleSide1, triangleSide2, triangleSide3))
            {
                return "Is an isosceles triangle";
            }
                return "Is a scalene triangle";       
        }

        private static bool TwoSidesEqual(int triangleSide1, int triangleSide2, int triangleSide3)
        {
            return triangleSide1 == triangleSide2 || triangleSide1 == triangleSide3 || triangleSide2 == triangleSide3;
        }

        private static bool ValidTriangle(int triangleSide1, int triangleSide2, int triangleSide3)
        {
            return triangleSide1 + triangleSide2 > triangleSide3 && triangleSide1 + triangleSide3 > triangleSide2 &&
                   triangleSide2 + triangleSide3 > triangleSide1;
        }

        private static bool AllSidesEqual(int triangleSide1, int triangleSide2, int triangleSide3)
        {
            return triangleSide1 == triangleSide2 && triangleSide2 == triangleSide3;
        }

        public static void GetInputAndReturnResult()
        {
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
    }
}

