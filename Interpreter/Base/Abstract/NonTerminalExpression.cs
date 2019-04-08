using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Interpreter.Base.Abstract
{
    public class NonTerminalExpression : IExpression
    {
        protected IExpression left, right;

        protected NonTerminalExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public virtual int Interpret()
        {
            throw new NotImplementedException("Must override!");
        }
    }
}
