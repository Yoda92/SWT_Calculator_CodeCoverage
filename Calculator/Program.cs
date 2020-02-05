using System;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            return a / b;
        }

        public double Divide(double divisor)
        {
            Accumulator = Divide(Accumulator, divisor);
            return Accumulator;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        
        public double Add(double addend)
        {
            Accumulator = Add(Accumulator, addend);
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = Subtract(Accumulator, subtractor);
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = Multiply(Accumulator, multiplier);
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Power(double exponent)
        {
            Accumulator = Power(Accumulator, exponent);
            return Accumulator;
        }

        public double Modulus(double a, double b)
        {
            return a % b;
        }

        public double Modulus(double a)
        {
            Accumulator = Modulus(Accumulator, a);
            return Accumulator;
        }
    }
}
