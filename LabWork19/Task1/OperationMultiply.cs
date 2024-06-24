namespace Task1
{
    public class OperationMultiply : IStrategy
    {
        public int DoOperation(int variable1, int variable2) => variable1 * variable2;
    }
}