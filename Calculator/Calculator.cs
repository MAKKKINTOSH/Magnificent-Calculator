using System;
using System.Windows;
using Magnificent_Calculator;

namespace Magnificent_Calculator
{
    class Calculator
    {
        public decimal Number_1 { get; set; }
        public decimal Number_2 { get; set; }
        public string Operator { get; set; }
        public decimal Calculate()
        {
            decimal result = Operator switch
            {
                "+" => Operations.Addition(Number_1, Number_2),
                "-" => Operations.Substraction(Number_1, Number_2),
                "*" => Operations.Multiplication(Number_1, Number_2),
                "/" => Operations.Division(Number_1, Number_2),
                "xⁿ" => Operations.Power(Number_1, Number_2),
            };
            return result;
        }
    }
}
