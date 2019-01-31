using System;
using Interpreter.Base.Interfaces;
using Interpreter.Implementation;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpression expr;

            while(true)
            {
                Console.Write("Give formula: ");
                var formula = Console.ReadLine();
                expr = FormulaExpression.Make(formula);
                
                Console.WriteLine(expr.Interpret());
                Console.WriteLine();
            }
        }
    }
}
