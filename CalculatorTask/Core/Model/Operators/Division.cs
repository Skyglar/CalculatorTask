using System;

namespace CalculatorTask.Operators
{
    public sealed class Division : BaseOperator
    {
        public override PriorityType Priority { get; } = PriorityType.Medium;

        public Division()
        {
        }

        public override Number Calculate(Number a, Number b)
        {
            if (b.Value == 0)
            {
                throw new Exception();
            }
            return new Number(a.Value / b.Value);
        }
    }
}
