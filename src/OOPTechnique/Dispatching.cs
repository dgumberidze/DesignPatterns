using System;

namespace OOPTechnique.Dispatching.ChainOfObjects
{
    public class Link1
    {
        public void Method()
        {
            Console.WriteLine("Link1");
        }
    }


    public class Link2
    {
        public void Method()
        {
            Link1 link1 = new Link1();
            link1.Method();
            
            Console.WriteLine("Link2");
        }
    }

    public class Link3
    {
        public void Method()
        {
            Link2 link2 = new Link2();
            link2.Method();

            Console.WriteLine("Link3");
        }
    }

    public class Client
    {
        public static void Main()
        {
            Link3 chain = new Link3();
            chain.Method();
        }
    }
}


namespace OOPTechnique.Dispatching.PublisherSubscriber
{
    public class Publisher
    {
        public void SendMessageTo(Subscriber subscriber)
        {
            subscriber.CallOperationOn(this);
        }

        public void Operation()
        {
            Console.WriteLine("Operation done!");
        }
    }


    public class Subscriber
    {
        public void CallOperationOn(Publisher publisher)
        {
            publisher.Operation();
        }
    }

    public class Client
    {
        public static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            //შეტყობინების გაგზავნა ხელმომწერთან
            publisher.SendMessageTo(subscriber);
        }
    }
}
