using System;

namespace CalculatorTask.Operators
{
    public sealed class Multiplication : BaseOperator
    {
        public override PriorityType Priority { get; } = PriorityType.Medium;
        public Multiplication() 
        {
        }

        public override Number Calculate(Number a, Number b)
        {
            return new Number(a.Value * b.Value);
        }
    }
}
