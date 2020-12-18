using CalculatorTask.Service;
using System;

namespace CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new CalculateEngine(
                new ExpressionCalculationService(),
                new StringExpressionSource(),
                new StringExpressionParser());

            Console.WriteLine(engine.Calculate());
        }
    }
}
