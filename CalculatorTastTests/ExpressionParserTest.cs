using System;
using Xunit;
using CalculatorTask;

namespace CalculatorTastTests
{
    public class ExpressionParserTest
    {
        private string str = @"3+6-5*(2-4*(3-15+60\3))+12-2";
        [Fact]
        public void Test1()
        {
            BaseExpressionParser parser = new StringExpressionParser();
            parser.Parse(str);
        }
    }
}
