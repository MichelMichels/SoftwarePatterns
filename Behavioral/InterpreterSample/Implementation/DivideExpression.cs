using SoftwarePatterns.Behavioral.Interpreter.Base.Abstract;
using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Interpreter.Implementation;

internal class DivideExpression : NonTerminalExpression
{
    private DivideExpression(IExpression left, IExpression right) : base(left, right)
    { }

    public static DivideExpression Make(IExpression left, IExpression right) => new DivideExpression(left, right);

    public override int Interpret()
    {
        return left.Interpret() / right.Interpret();
    }
}