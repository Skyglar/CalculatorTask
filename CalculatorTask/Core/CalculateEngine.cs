using System;
using System.Collections.Generic;
using CalculatorTask.Service;

namespace CalculatorTask
{
    public sealed class CalculateEngine
    {
        private IExpressionService _expressionService;
        private IExpressionSource _expressionSource;
        private BaseExpressionParser _expressionParser;

        public CalculateEngine(
            IExpressionService expressionService,
            IExpressionSource expressionSource,
            BaseExpressionParser expressionParser)
        {
            _expressionService = expressionService;
            _expressionSource = expressionSource;
            _expressionParser = expressionParser;
        }

        public double Calculate()
        {
            List<string> expressionList = _expressionParser
                .Parse(_expressionSource.GetExpressionFromSource());

            return _expressionService.GetCalculationResult(expressionList);
        }
    }
}
