namespace Observer.Structure.PullModel
{
    public class Client
    {
        public static void ClientMain()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));
            subject.State = "Some state";
            subject.Notify();
        }
    }
}
