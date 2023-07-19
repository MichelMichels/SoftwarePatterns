using SoftwarePatterns.Behavioral.Interpreter.Base;
using SoftwarePatterns.Behavioral.Interpreter.Base.Abstract;
using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Interpreter.Implementation;

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