

namespace CalculatorTask.Operators
{
    public sealed class Subtraction : BaseOperator
    {
        public override PriorityType Priority { get; } = PriorityType.Low;
        public Subtraction()
        {
        }

        public override Number Calculate(Number a, Number b)
        {
            return new Number(a.Value - b.Value);
        }
    }
}
