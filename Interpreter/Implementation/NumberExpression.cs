using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.Base.Interfaces;

namespace Interpreter.Implementation
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
