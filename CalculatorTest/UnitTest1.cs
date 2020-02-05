using System;
using NUnit.Framework;
using Calculator;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

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

        [Test]
        public void TestConstructor()
        {
            Assert.That(_calc.Accumulator == 0);
        }

        // TESTING DIVIDE
        [TestCase(2, 2, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(4, 0.5, 8)]
        public void TestDivide(double a, double b, double result)
        {
            Assert.That(_calc.Divide(a, b), Is.EqualTo(result).Within(0.05));
        }

        [Test]
        public void TestDivideException()
        {
            Assert.Throws<System.DivideByZeroException>(() => _calc.Divide(10, 0));
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

        [Test]
        public void TestAccumulatorAdd()
        {
            _calc.Add(5);
            Assert.That(_calc.Accumulator, Is.EqualTo(5));
            _calc.Add(3);
            Assert.That(_calc.Accumulator, Is.EqualTo(8));
            _calc.Add(4);
            Assert.That(_calc.Accumulator, Is.EqualTo(12));
        }

        [Test]
        public void TestAccumulatorSub()
        {
            _calc.Subtract(5);
            Assert.That(_calc.Accumulator, Is.EqualTo(-5));
            _calc.Subtract(-6);
            Assert.That(_calc.Accumulator, Is.EqualTo(1));
            _calc.Subtract(2);
            Assert.That(_calc.Accumulator, Is.EqualTo(-1));
        }

        [Test]
        public void TestAccumulatorMultiply()
        {
            _calc.Add(15);
            _calc.Multiply(2);
            Assert.That(_calc.Accumulator, Is.EqualTo(30));
            _calc.Multiply(0.5);
            Assert.That(_calc.Accumulator, Is.EqualTo(15));
            _calc.Multiply(-1);
            Assert.That(_calc.Accumulator, Is.EqualTo(-15));
        }

        [Test]
        public void TestAccumulatorDivide()
        {
            _calc.Add(60);
            _calc.Divide(2);
            Assert.That(_calc.Accumulator, Is.EqualTo(30));
            _calc.Divide(2);
            Assert.That(_calc.Accumulator, Is.EqualTo(15));
            _calc.Divide(3);
            Assert.That(_calc.Accumulator, Is.EqualTo(5));

            //Dividing by zero fails
            Assert.Throws<System.DivideByZeroException>(() => _calc.Divide(0));
        }

        [Test]
        public void TestAccumulatorPower()
        {
            _calc.Add(2);
            _calc.Power(2);
            Assert.That(_calc.Accumulator, Is.EqualTo(4));
            _calc.Power(3);
            Assert.That(_calc.Accumulator, Is.EqualTo(64));
            _calc.Power(0.5);
            Assert.That(_calc.Accumulator, Is.EqualTo(8));
        }

        [Test]
        public void TestAccumulatorClear()
        {
            _calc.Add(2);
            Assert.That(_calc.Accumulator, Is.EqualTo(2));
            _calc.Clear();
            Assert.That(_calc.Accumulator, Is.EqualTo(0));
            
        }
    }
}