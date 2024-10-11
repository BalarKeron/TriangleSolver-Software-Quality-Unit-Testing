using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleSolver;

namespace TriangleUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_EquilateralTriangle()
        {
            // Arrange
            int side1 = 8, side2 = 8, side3 = 8;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        [TestMethod]
        public void Test_IsoscelesTriangle1()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 7;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [TestMethod]
        public void Test_IsoscelesTriangle2()
        {
            // Arrange
            int side1 = 7, side2 = 9, side3 = 9;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [TestMethod]
        public void Test_IsoscelesTriangle3()
        {
            // Arrange
            int side1 = 6, side2 = 6, side3 = 4;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [TestMethod]
        public void Test_ScaleneTriangle1()
        {
            // Arrange
            int side1 = 3, side2 = 4, side3 = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void Test_ScaleneTriangle2()
        {
            // Arrange
            int side1 = 6, side2 = 8, side3 = 10;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void Test_ScaleneTriangle3()
        {
            // Arrange
            int side1 = 7, side2 = 9, side3 = 11;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void Test_ScaleneTriangle4()
        {
            // Arrange
            int side1 = 2, side2 = 3, side3 = 4;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void Test_ScaleneTriangle5()
        {
            // Arrange
            int side1 = 5, side2 = 12, side3 = 13;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void Test_ZeroLengthTriangle1()
        {
            // Arrange
            int side1 = 0, side2 = 5, side3 = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [TestMethod]
        public void Test_ZeroLengthTriangle2()
        {
            // Arrange
            int side1 = 6, side2 = 0, side3 = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [TestMethod]
        public void Test_ZeroLengthTriangle3()
        {
            // Arrange
            int side1 = 0, side2 = 8, side3 = 9;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [TestMethod]
        public void Test_InvalidTriangle1()
        {
            // Arrange
            int side1 = 1, side2 = 2, side3 = 10;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }

        [TestMethod]
        public void Test_InvalidTriangle2()
        {
            // Arrange
            int side1 = 2, side2 = 3, side3 = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }

        [TestMethod]
        public void Test_InvalidTriangle3()
        {
            // Arrange
            int side1 = -5, side2 = 4, side3 = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }

    }
}
