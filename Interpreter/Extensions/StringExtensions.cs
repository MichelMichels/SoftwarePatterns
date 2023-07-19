using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using SoftwarePatterns.Behavioral.Interpreter.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwarePatterns.Behavioral.Interpreter.Extensions;

public static class StringExtensions
{
    public static IExpression ToExpression(this string input)
    {
        return int.TryParse(input, out int result) ? (IExpression)NumberExpression.Make(result) : FormulaExpression.Make(input);
    }

    public static string RemoveOuterBrackets(this string input)
    {
        int startBracketsCount = input.TakeWhile(x => x.Equals('(')).Count();
        int endBracketsCount = input.Reverse().TakeWhile(x => x.Equals(')')).Count();
        int bracketsToRemoveCount = Math.Min(startBracketsCount, endBracketsCount);

        return input.Substring(bracketsToRemoveCount, input.Length - 2 * bracketsToRemoveCount);
    }
}