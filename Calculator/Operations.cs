using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Magnificent_Calculator
{
    class Operations
    {
        public static decimal Addition(decimal first, decimal second)
        {
            return first + second;
        }
        public static decimal Substraction(decimal first, decimal second)
        {
            return first - second;
        }
        public static decimal Multiplication(decimal first, decimal second)
        {
            return first * second;
        }
        public static decimal Division(decimal first, decimal second)
        {
            return first / second;
        }
        public static decimal Power(decimal first, decimal second)
        {
            return (decimal)Math.Pow((double)first, (double)second);
        }
    }
}
