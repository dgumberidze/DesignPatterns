namespace Decorator.Structure
{
    public class Client
    {
        public static void ClientMain()
        {
            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;
            decoratorB.Operation();
        }
    }
}