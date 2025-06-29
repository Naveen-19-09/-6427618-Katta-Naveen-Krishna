using NUnit.Framework;
using CalcLibrary; // ✅ needed to use SimpleCalculator

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new SimpleCalculator();
        }

        [Test]
        public void AddTest()
        {
            var result = _calculator.Addition(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
