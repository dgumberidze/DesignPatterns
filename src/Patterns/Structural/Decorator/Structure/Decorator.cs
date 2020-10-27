using System;

namespace Decorator.Structure
{
    public abstract class Decorator : Component
    {
        public Component Component { get; set; }

        public override void Operation()
        {
            Component?.Operation();
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        private string addedState = "Some state";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addedState);
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        private void AddedBehavior()
        {
            Console.WriteLine("Some behavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
