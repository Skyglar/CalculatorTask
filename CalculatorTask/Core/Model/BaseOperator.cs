

namespace CalculatorTask.Operators
{
    public abstract class BaseOperator
    {
        public abstract PriorityType Priority { get; }
        public abstract Number Calculate(Number a, Number b);
    }
}
