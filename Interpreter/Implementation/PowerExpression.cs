using SoftwarePatterns.Behavioral.Interpreter.Base.Abstract;
using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Interpreter.Implementation
{
    public class PowerExpression : NonTerminalExpression
    {
        private PowerExpression(IExpression left, IExpression right) : base(left, right)
        { }

        public static PowerExpression Make(IExpression left, IExpression right) => new PowerExpression(left, right);

        public override int Interpret()
        {
            return (int)Math.Pow(left.Interpret(), right.Interpret());
        }
    }
}
