namespace Task1
{
    public class Context
    {
        private IStrategy strategy;

        internal Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int variable1, int variable2) => strategy.DoOperation(variable1, variable2);
    }
}