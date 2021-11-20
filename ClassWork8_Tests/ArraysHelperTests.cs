using ClassWork8_Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork8_Tests
{
    public class ArraysHelperTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new[] { 10, 4, 3, 2}, 10)]
        [TestCase(new[] { -5, 2, 0 }, 2)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { -1 }, -1)]
        public void Max_WhenFilledArrayPassed_ShouldFindMaxValue(int[] array, int expected)
        {
            int actual = ArraysHelper.Max(array);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Max_WhenEmptyArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                ArraysHelper.Max(new int[] { });
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("No max element in empty array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void Max_WhenNullArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                ArraysHelper.Max(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("No max element in empty array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new[] { 10, 7, 3, -5 }, 2)]
        [TestCase(new[] { -5, 1, 0 }, 1)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { -1 }, 0)]
        [TestCase(new[] { 0, 0, 0}, 0)]
        [TestCase(new int[] { }, 0)]
        public void GetSumOfElementsWithOddIndexes_WhenNotNullArrayPassed_ShouldSumElements
            (int[] array, int expected)
        {
            int actual = ArraysHelper.GetSumOfElementsWithOddIndexes(array);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSumOfElementsWithOddIndexes_WhenNullArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                ArraysHelper.GetSumOfElementsWithOddIndexes(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Invalid array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 3 }, new[] { 3 })]
        [TestCase(new int[] {}, new int[] {})]
        public void Reverse_WhenNotNullArrayPassed_ShouldReverseArray
            (int[] array, int[] expected)
        {
            ArraysHelper.Reverse(array);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Reverse_WhenNullArrayPassed_ShouldThrowArgumentNullException()
        {
            try
            {
                ArraysHelper.Reverse(null);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
