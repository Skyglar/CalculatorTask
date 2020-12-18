using System.Collections.Generic;

namespace CalculatorTask.Service
{
    public interface IExpressionService
    {
        double GetCalculationResult(List<string> expression);
    }
}