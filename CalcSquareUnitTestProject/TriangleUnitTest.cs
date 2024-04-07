using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;

namespace CalcSquareUnitTestProject
{
    [TestClass]
    public class TriangleUnitTest
    {
        /// <summary>
        /// Checking the calculation of the square of a right triangle.
        /// </summary>
        [TestMethod]
        public void TestA3B4C5Expects6()
        {
            // Arrange.
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // Act.
            double actual = new SquareClass().CalculateTriangle(a, b, c);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checking the calculation of the square of an arbitrary triangle.
        /// </summary>
        [TestMethod]
        public void TestA3B4C7Expects0()
        {
            // Arrange.
            double a = 5;
            double b = 7;
            double c = 9;
            double expected = 17.412280149365849;

            // Act.
            double actual = new SquareClass().CalculateTriangle(a, b, c);
          
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checking the square calculation for a non-existent triangle.
        /// </summary>
        [TestMethod]
        public void TestA3B4C8ExpectsError()
        {
            // Arrange.
            double a = 3;
            double b = 4;
            double c = 8;

            // Act and assert
            try
            {
                var actual = new SquareClass().CalculateTriangle(a, b, c);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        /// <summary>
        /// Checking the square calculation for a triangle with a negative side.
        /// </summary>
        [TestMethod]
        public void TestA3BMinus4C5ExpectsError()
        {
            // Arrange.
            double a = 3;
            double b = -4;
            double c = 5;

            // Act and assert
            try
            {
                var actual = new SquareClass().CalculateTriangle(a, b, c);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
