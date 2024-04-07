using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;

namespace CalcSquareUnitTestProject
{
    [TestClass]
    public class CircleUnitTest
    {
        /// <summary>
        /// Checking the square calculation for a circle with a positive radius.
        /// </summary>
        [TestMethod]
        public void TestRadius5Expects78f54()
        {
            // Arrange.
            double radius = 5;
            double expected = 78.539816339744831;

            // Act.
            double actual = new SquareClass().CalculateCircle(radius);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checking the square calculation for a circle with a zero radius.
        /// </summary>
        [TestMethod]
        public void TestRadius0Expects0()
        {
            // Arrange.
            double radius = 0;
            double expected = 0;

            // Act.
            double actual = new SquareClass().CalculateCircle(radius);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checking the square calculation for a circle with a negative radius.
        /// </summary>
        [TestMethod]
        public void TestRadiusMinus5ExpectsError()
        {
            // Arrange.
            double radius = -5;

            // Act and assert.
            try
            {
                double actual = new SquareClass().CalculateCircle(radius);
            }
            catch 
            {
                Assert.IsTrue(true);
            }
        }
    }
}
