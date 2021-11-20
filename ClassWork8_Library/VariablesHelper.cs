using System;

namespace ClassWork8_Library
{
    public class VariablesHelper
    {
        public static double CalculateEquation(double a, double b)
        {
            if ((b - a) == 0)
            {
                throw new DivideByZeroException("B - A == 0");
            }

            return (5 * a + b * b) / (b - a);
        }
    }
}