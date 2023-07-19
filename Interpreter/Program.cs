using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using SoftwarePatterns.Behavioral.Interpreter.Implementation;
using System;

namespace SoftwarePatterns.Behavioral.Interpreter;

class Program
{
    static void Main(string[] args)
    {
        IExpression expr;

        while (true)
        {
            Console.Write("Give formula: ");
            var formula = Console.ReadLine();
            expr = FormulaExpression.Make(formula);

            Console.WriteLine(expr.Interpret());
            Console.WriteLine();
        }
    }
}