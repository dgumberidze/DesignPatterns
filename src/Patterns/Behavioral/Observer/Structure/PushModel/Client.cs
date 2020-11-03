namespace Observer.Structure.PushModel
{
    public class Client
    {
        public static void ClientMain()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver());
            subject.Attach(new ConcreteObserver());
            subject.State = "Some state";
            subject.Notify();
        }
    }
}
