using System;
using System.Text;
using System.Collections.Generic;

namespace CalculatorTask
{
    public class StringExpressionParser : BaseExpressionParser
    {
        public StringExpressionParser()
        {
        }

        // Divides string into list of numbers and operators 
        public override List<string> Parse(string expression)
        {
            List<string> elements = new List<string>();
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                while (i < expression.Length && Char.IsDigit(expression[i]))
                {
                    temp.Append(expression[i++]);
                }
                if (temp.Length != 0)
                {
                    elements.Add(temp.ToString());
                    if (i < expression.Length)
                    {
                        elements.Add(expression[i].ToString());
                    }
                    temp.Clear();
                }
                else
                {
                   elements.Add(expression[i].ToString());
                }
            }
            return elements;
        }
    }
}