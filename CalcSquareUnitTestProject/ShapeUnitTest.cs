using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;

namespace CalcSquareUnitTestProject
{
    [TestClass]
    public class ShapeUnitTest
    {
        /// <summary>
        /// Checking the square calculation for the circle.
        /// </summary>
        [TestMethod]
        public void TestRadius5Expects78f54()
        {
            // Arrange.
            double radius = 5;
            double expected = 78.539816339744831;

            // Act.
            double actual = new SquareClass().СalculateShape(new double[] { radius });

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checking the square calculation for a triangle.
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
            double actual = new SquareClass().СalculateShape(new double[] { a, b, c });

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
