using ClassWork8_Library;
using NUnit.Framework;
using System;

namespace ClassWork8_Tests
{
    public class VariablesHelperTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(2, 3, 19)]
        [TestCase(-2, 1, -3)]
        public void CalculateEquation_WhenANotEqualB_ShouldCalcualteEquation
            (double a, double b, double expected)
        {
            //Act
            double actual = VariablesHelper.CalculateEquation(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(100)]
        public void CalculateEquation_WhenAEqualB_ShouldThrowDivideByZeroException
            (double n)
        {
            try
            {
                VariablesHelper.CalculateEquation(n, n);
            }
            catch(DivideByZeroException ex)
            {
                Assert.AreEqual("B - A == 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }


    }
}