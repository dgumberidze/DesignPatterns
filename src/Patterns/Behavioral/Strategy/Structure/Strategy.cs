using System;

namespace Strategy.Structure
{
    public abstract class Strategy
    {
        public abstract void Algorithm();
    }

    public class ConcreteStrategyA : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("ConcreteStrategyA");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("ConcreteStrategyB");
        }
    }
}
