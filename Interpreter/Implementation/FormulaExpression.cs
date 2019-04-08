using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SoftwarePatterns.Behavioral.Interpreter.Base.Interfaces;
using SoftwarePatterns.Behavioral.Interpreter.Base.Enums;
using SoftwarePatterns.Behavioral.Interpreter.Extensions;

namespace SoftwarePatterns.Behavioral.Interpreter.Implementation
{
    public class FormulaExpression : IExpression
    {
        private readonly Dictionary<char, MathOperation> OperationsBySymbol = new Dictionary<char, MathOperation>
        {
            { '+', MathOperation.Add },
            { '-', MathOperation.Subtract },
            { '*', MathOperation.Multiply },
            { '/', MathOperation.Divide },
            { '^', MathOperation.Power }
        };

        // Constants
        private const char AddOperator = '+';
        private const char SubtractOperator = '-';
        private const char MultiplyOperator = '*';
        private const char DivideOperator = '/';
        private const char PowerOperator = '^';

        // Fields
        private string context;

        // Constructor
        private FormulaExpression(string context)
        {
            this.context = context.Replace(" ", "");
        }

        public static FormulaExpression Make(string context) => new FormulaExpression(context);

        // IExpression members
        public int Interpret()
        {
            context = context.RemoveOuterBrackets();
            if(context.Where(x => OperationsBySymbol.ContainsKey(x)).Any())
            {
                foreach(var operationBySymbol in OperationsBySymbol)
                {
                    int openBracketsCount = 0, closeBracketsCount = 0;

                    for (int i = 0; i < context.Length; i++)
                    {
                        if (context[i] == '(')
                            openBracketsCount++;

                        if (context[i] == ')')
                            closeBracketsCount++;

                        if (openBracketsCount == closeBracketsCount && context[i] == operationBySymbol.Key)
                        {
                            var left = context.Substring(0, i).ToExpression();
                            var right = context.Substring(i + 1).ToExpression();

                            switch (operationBySymbol.Value)
                            {
                                case MathOperation.Add:
                                    return AddExpression.Make(left, right).Interpret();
                                case MathOperation.Subtract:
                                    return SubtractExpression.Make(left, right).Interpret();
                                case MathOperation.Multiply:
                                    return MultiplyExpression.Make(left, right).Interpret();
                                case MathOperation.Divide:
                                    return DivideExpression.Make(left, right).Interpret();
                                case MathOperation.Power:
                                    return PowerExpression.Make(left, right).Interpret();
                            }
                        }
                    }
                }
            }

            return int.TryParse(context, out int result) ? NumberExpression.Make(result).Interpret() : 0;
        }
    }
}
