using System;
using System.Collections.Generic;
using CalculatorTask.Operators;

namespace CalculatorTask.Service
{
    public sealed class ExpressionCalculationService : IExpressionService
    {
        private List<string> _expression;
        private OperatorFactory _operatorFactory;

        public ExpressionCalculationService()
        {
            _operatorFactory = new OperatorFactory();
        }
        public double GetCalculationResult(List<string> expression)
        {
            _expression = expression;
            return CalculateExpression(_expression);
        }

        // Divide by parentheses and calculate expression
        private double CalculateExpression(List<string> list)
        {
            int lastLeftParentheses = -1;
            int rightParentheses = -1;
            string result = "";

            // Find deepest parantheses and pass sub expression to calculate
            // in CalculateSubExpression() method
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "(")
                {
                    lastLeftParentheses = i;
                }
                else if (list[i] == ")")
                {
                    rightParentheses = i;
                    // Result of sub expression
                    result = CulculateSubExpression(
                        list.GetRange(lastLeftParentheses + 1, 
                                      rightParentheses - (lastLeftParentheses + 1)));

                    // Replace sub expression in parentheses with result
                    List<string> newList = new List<string>();
                    newList.AddRange(list.GetRange(0, lastLeftParentheses));
                    newList.Add(result);

                    for (int j = rightParentheses + 1; j < list.Count; j++)
                    {
                        newList.Add(list[j]);
                    }
                    list = newList;
                    i = 0;
                }
            }
            // Calculate the rest
            return Double.Parse(CulculateSubExpression(list));
        }

        // Method CalculateSubExpression() takes sub expression via list of strings
        // and calculate expression considering PriorityType.
        // Return result of calculation as string type 
        private string CulculateSubExpression(List<string> expressionList)
        {
            for (int i = 0; i < expressionList.Count; i++)
            {
                if (!int.TryParse(expressionList[i], out int place))
                {
                    var _operator = _operatorFactory.Create(expressionList[i]);
                    if (_operator.Priority == PriorityType.High)
                    {
                        Number number = _operator.Calculate(new Number(double.Parse(expressionList[i - 1])),
                            new Number(double.Parse(expressionList[i + 1])));

                        List<string> temp = new List<string>();
                        temp.AddRange(expressionList.GetRange(0, i - 1));
                        temp.Add(number.Value.ToString());
                        for (int j = i + 2; j < expressionList.Count; j++)
                        {
                            temp.Add(expressionList[j]);
                        }
                        expressionList = temp;
                        i--;
                    }
                }
            }

            for (int i = 0; i < expressionList.Count; i++)
            {
                if (!int.TryParse(expressionList[i], out int place))
                {
                    var _operator = _operatorFactory.Create(expressionList[i]);
                    if (_operator.Priority == PriorityType.Medium)
                    {
                        Number number = _operator.Calculate(new Number(double.Parse(expressionList[i - 1])),
                             new Number(double.Parse(expressionList[i + 1])));

                        List<string> temp = new List<string>();
                        temp.AddRange(expressionList.GetRange(0, i - 1));
                        temp.Add(number.Value.ToString());
                        for (int j = i + 2; j < expressionList.Count; j++)
                        {
                            temp.Add(expressionList[j]);
                        }
                        expressionList = temp;
                        i--;
                    }
                }
            }

            for (int i = 0; i < expressionList.Count; i++)
            {
                if (!int.TryParse(expressionList[i], out int place))
                {
                    var _operator = _operatorFactory.Create(expressionList[i]);
                    if (_operator.Priority == PriorityType.Low)
                    {
                        Number number = _operator.Calculate(new Number(double.Parse(expressionList[i - 1])),
                            new Number(double.Parse(expressionList[i + 1])));

                        List<string> temp = new List<string>();
                        temp.AddRange(expressionList.GetRange(0, i - 1));
                        temp.Add(number.Value.ToString());
                        for (int j = i + 2; j < expressionList.Count; j++)
                        {
                            temp.Add(expressionList[j]);
                        }
                        expressionList = temp;
                        i--;
                    }
                }
            }
            return expressionList[0];
        }
    }
}
