namespace Task1
{
    public class OperationAdd : IStrategy
    {
        public int DoOperation(int variable1, int variable2) => variable1 + variable2;
    }
}