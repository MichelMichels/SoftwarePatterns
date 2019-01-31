using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.Base;
using Interpreter.Base.Abstract;
using Interpreter.Base.Interfaces;

namespace Interpreter.Implementation
{
    internal class AddExpression : NonTerminalExpression
    {      
        private AddExpression(IExpression left, IExpression right) : base(left, right)
        { }

        public static AddExpression Make(IExpression left, IExpression right) => new AddExpression(left, right);

        public override int Interpret()
        {
            return left.Interpret() + right.Interpret();
        }
    }
}
