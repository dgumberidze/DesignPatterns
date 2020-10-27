namespace Strategy.Structure
{
    public class Client
    {
        public static void ClientMain()
        {
            Context context = new Context(new ConcreteStrategyA());
            context.ContextMethod();

            context = new Context(new ConcreteStrategyB());
            context.ContextMethod();
        }
    }
}