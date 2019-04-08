using System;
using System.Collections.Generic;
using System.Text;
using SoftwarePatterns.Behavioral.Interpreter.Base.Abstract;
using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;

namespace SoftwarePatterns.Behavioral.Interpreter.Implementation
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
