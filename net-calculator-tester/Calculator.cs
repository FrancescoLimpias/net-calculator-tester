using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {

        public static float Add(float a, float b)
        { return a + b; }

        public static float Subtract(float a, float b)
        { return a - b; }

        public static float Divide(float a, float b)
        { return a / b; }

        public static float Multiply(float a, float b)
        { return a * b; }

        public static double Power(float b, float a)
        {
            if (a == 0)
            {
                return 1;
            }

            double result = Power(b, a / 2);

            if (a % 2 == 0)
            {
                return result * result;
            }
            else if (a > 0)
            {
                return b * result * result;
            }
            else
            {
                return (result * result) / b;
            }
        }

    }
}
