using Core.common;

namespace Core.DifferentImplementation
{
    public class EqualOperator:IOperator
    {
        public OperatorType Type
        {
            get { return OperatorType.Equals; }
        }
    }
}
