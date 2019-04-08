using System;
using System.Collections.Generic;
using System.Text;
using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;

namespace SoftwarePatterns.Behavioral.Interpreter.Implementation
{
    internal class NumberExpression : IExpression
    {
        private int number;

        private NumberExpression(int number)
        {
            this.number = number;
        }

        public static NumberExpression Make(int number) => new NumberExpression(number);

        public int Interpret()
        {
            return number;
        }
    }
}
