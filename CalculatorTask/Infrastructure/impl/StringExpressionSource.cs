
namespace CalculatorTask
{
    public class StringExpressionSource : IExpressionSource
    {
        public string ExpressionString { get; set; } = "3+6-5*(2-4*(3-15+60/3))+12-2";
        public string GetExpressionFromSource()
        {
            return ExpressionString;
        }
    }
}
