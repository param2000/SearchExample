using Core.common;

namespace Core.DifferentImplementation
{
    public class NotEqualOperator:IOperator
    {
        public OperatorType Type
        {
            get {return OperatorType.NotEquals; }
        }
    }
}
