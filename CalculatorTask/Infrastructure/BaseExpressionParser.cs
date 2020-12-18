using System.Collections.Generic;

namespace CalculatorTask
{
    public abstract class BaseExpressionParser
    {
        public abstract List<string> Parse(string expression);
    }
}