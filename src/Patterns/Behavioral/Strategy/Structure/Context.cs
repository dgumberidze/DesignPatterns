namespace Strategy.Structure
{
    public class Context
    {
        private readonly Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextMethod()
        {
            _strategy.Algorithm();
        }
    }
}