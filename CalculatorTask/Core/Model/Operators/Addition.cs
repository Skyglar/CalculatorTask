

namespace CalculatorTask.Operators
{
    public sealed class Addition : BaseOperator
    {
        public override PriorityType Priority { get; } = PriorityType.Low;
        public Addition() 
        {
        }

        public override Number Calculate(Number a, Number b)
        {

            return new Number(a.Value + b.Value);
        }
    }
}
