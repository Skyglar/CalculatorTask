using System;
using CalculatorTask.Operators;

namespace CalculatorTask
{
    public sealed class OperatorFactory
    {
        public OperatorFactory()
        {
        }

        public BaseOperator Create(string type)
        {
            try
            {
                return (BaseOperator)Activator.CreateInstance(
                    Type.GetType($"CalculatorTask.Operators.{StringToOperatorTypeEnum(type)}"));
            }
            catch
            {
                return new UnknownOperator();
            }
        }

        private OperatorType StringToOperatorTypeEnum(string _operator)
        {
            if (_operator == "+")
            {
                return OperatorType.Addition;
            }
            if (_operator == "-")
            {
                return OperatorType.Subtraction;
            }
            if (_operator == "*")
            {
                return OperatorType.Multiplication;
            }
            if (_operator == "/")
            {
                return OperatorType.Division;
            }
            return OperatorType.Unknown;
        }

    }
}
