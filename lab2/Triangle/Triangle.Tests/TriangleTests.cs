using System;
using NUnit.Framework;

namespace Triangle.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(5, 5, 5, ExpectedResult = true)]
        [TestCase(5, 6, 6, ExpectedResult = true)]
        [TestCase(5, 10, 11, ExpectedResult = true)]
        [TestCase(2, 2, 3, ExpectedResult = true)]
        [TestCase(1, 100, 100, ExpectedResult = true)]
        [TestCase(12, 17, 28, ExpectedResult = true)]
        [TestCase(3, 5, 5, ExpectedResult = true)]
        [TestCase(3.523, 5.123, 5.765, ExpectedResult = true)]
        public bool Triangle_InputNumbers_True(double a, double b, double c)
            => Triangle.IsTriangle(a, b, c);

        [TestCase(3, 5, 15, ExpectedResult = false)]
        [TestCase(1, 2, 3, ExpectedResult = false)]
        [TestCase(5.5, 3.6, 10.3, ExpectedResult = false)]
        [TestCase(2, 7, 3, ExpectedResult = false)]
        public bool Triangle_InputNumbers_False(double a, double b, double c)
           => Triangle.IsTriangle(a, b, c);

        [TestCase(-2, 1, 2)]
        [TestCase(2, -1, 2)]
        [TestCase(2, 1, -2)]
        public void Triangle_IncorrectNumbers_ThrowsArgumentException(double a, double b, double c)
                => Assert.Throws<ArgumentException>(() => Triangle.IsTriangle(a, b, c));
    }
}
