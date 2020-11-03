using System;

namespace Mediator.Structure
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }

    public abstract class Colleague
    {
        protected Mediator _mediator;

        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
    }

    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }
        
        public override void Send(string msg, Colleague collegue)
        {
            if (collegue == Colleague1)
                Colleague2.Notify(msg);
            else
                Colleague1.Notify(msg);
        }
    }


    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        { }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        { }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }


    public class Client
    {
        public static void ClientMain()
        {
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("Message 1");
            colleague2.Send("Message 2");
        }
    }
}
