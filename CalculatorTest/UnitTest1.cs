using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    public class Tests
    {
        private Calculator.Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator.Calculator();
        }

        // TESTING DIVIDE
        [TestCase(2, 2, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(10, 0, 0)]
        public void TestDivide(double a, double b, double result)
        {
            Assert.That(_calc.Divide(a, b), Is.EqualTo(result).Within(0.05));
        }

        // TESTING ADD
        [TestCase(3, 7, 10)]
        [TestCase(12.5,-7.5,5)]
        [TestCase(3.3,4.3,7.6)]
        public void TestAdd(double a, double b, double result)
        {
            Assert.That(_calc.Add(a,b), Is.EqualTo(result).Within(0.05));
        }


        // TESTING SUBTRACT
        [TestCase(7,3,4)]
        [TestCase(20.5,8.25,12.25)]
        [TestCase(6.7,4.3,2.4)]
        public void TestSubtract(double a, double b, double result)
        {
            Assert.That(_calc.Subtract(a,b), Is.EqualTo(result).Within(0.05));
        }


        // TESTING MULTIPLY
        [TestCase(2, 3, 6)]
        [TestCase(5, 2.5, 12.5)]
        [TestCase(9, 9, 81)]
        public void TestMultiply1(double a, double b, double result)
        {
            Assert.That(_calc.Multiply(a,b), Is.EqualTo(result).Within(0.05));
        }

     
        // TESTING POWER
        [TestCase(2, 3, 8)]
        [TestCase(3, 2, 9)]
        [TestCase(4, 3, 64)]
        public void TestPower(double a, double b, double result)
        {
            Assert.That(_calc.Power(a,b), Is.EqualTo(result).Within(0.05));
        }
    }
}