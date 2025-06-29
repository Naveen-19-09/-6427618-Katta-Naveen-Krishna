using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator = null;
        }

        [Test]
        public void Add_AddsTwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestCase(1, 1, 2)]
        [TestCase(5, 3, 8)]
        [TestCase(-1, -1, -2)]
        public void Add_WithTestCases_ReturnsExpectedResult(int a, int b, int expected)
        {
            int result = _calculator.Add(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
