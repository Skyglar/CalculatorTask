using CalculatorTask.Operators;

namespace CalculatorTask.Operators
{
    internal class UnknownOperator : BaseOperator
    {
        public override PriorityType Priority => throw new System.NotImplementedException();

        public override Number Calculate(Number a, Number b)
        {
            throw new System.NotImplementedException();
        }
    }
}