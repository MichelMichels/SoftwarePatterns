using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.Base.Abstract;
using Interpreter.Base.Interfaces;

namespace Interpreter.Implementation
{
    internal class SubtractExpression : NonTerminalExpression
    {
        private SubtractExpression(IExpression left, IExpression right) : base(left, right)
        { }

        public static SubtractExpression Make(IExpression left, IExpression right) => new SubtractExpression(left, right);

        public override int Interpret()
        {
            return left.Interpret() - right.Interpret();
        }
    }
}
