using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.Base.Interfaces;

namespace Interpreter.Implementation
{
    internal class MultiplyExpression : IExpression
    {
        private IExpression left, right;

        private MultiplyExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public static MultiplyExpression Make(IExpression left, IExpression right) => new MultiplyExpression(left, right);

        public int Interpret()
        {
            return left.Interpret() * right.Interpret();
        }
    }
}
