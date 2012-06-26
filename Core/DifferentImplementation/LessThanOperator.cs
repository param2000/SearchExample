using Core.common;

namespace Core.DifferentImplementation
{
    public class LessThanOperator:IOperator
    {
        public OperatorType Type
        {
            get { return OperatorType.LessThan; }
        }
    }
}
