using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCodeExercise
{
    [TestFixture]
    class TriangleTest
    {
        [TestCase(5,5,6)]
        [TestCase(5,4,4)]
        [TestCase(7,12,7)]
        public void Two_Sides_Equal_Test(int side1, int side2, int side3)
        {
            // Arrange
            int triangleSide1 = side1;
            int triangleSide2 = side2;
            int triangleSide3 = side3;

            // Act
            string result = Program.IsTriangle(triangleSide1, triangleSide2, triangleSide3);

            // Assert
            Assert.AreEqual("Is an isosceles triangle", result);
        }
        [Test]
        public void All_Sides_Equal_Passing_Test()
        {
            // Arrange
            int triangleSide1 = 5;
            int triangleSide2 = 5;
            int triangleSide3 = 5;

            // Act
            string result = Program.IsTriangle(triangleSide1, triangleSide2, triangleSide3);

            // Assert
            Assert.AreEqual("Is an equilateral triangle", result);
        }
      
        [TestCase(2,4,5)]
        [TestCase(8,4,5)]
        public void Is_Triangle_Passing(int side1, int side2, int side3) //two shorter sides must when added be larger than third side
        {
            // Arrange
            int triangleSide1 = side1;
            int triangleSide2 = side2;
            int triangleSide3 = side3;

            // Act
            string result = Program.IsTriangle(triangleSide1, triangleSide2, triangleSide3);

            // Assert
            Assert.AreEqual("Is a scalene triangle", result);
        }

        [TestCase(2,2,5)]
        [TestCase(2,2,4)]
        [TestCase(5,2,2)]
        [TestCase(2,5,2)]
        public void Is_Triangle_Failing(int side1, int side2, int side3) //two shorter sides must when added be larger than third side
        {
            // Arrange
            int triangleSide1 = side1;
            int triangleSide2 = side2;
            int triangleSide3 = side3;

            // Act
            string result = Program.IsTriangle(triangleSide1, triangleSide2, triangleSide3);

            // Assert
            Assert.AreEqual("Is not a triangle", result);
        }
    }
}
