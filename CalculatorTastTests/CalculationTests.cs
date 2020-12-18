using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CalculatorTask;
using CalculatorTask.Operators;

namespace CalculatorTastTests
{
    public class CalculationTests
    {
        [Fact]
        public void CutExpressionTest()
        {
            List<string> list = new StringExpressionParser().Parse(new StringExpressionSource().GetExpressionFromSource());
            CalculateEngine engine = new CalculateEngine(new StringExpressionSource(),
                new StringExpressionParser(),
                new OperatorFactory());

        }
    }
}
