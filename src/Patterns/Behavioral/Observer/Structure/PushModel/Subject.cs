using System.Collections.Generic;

namespace Observer.Structure.PushModel
{
    public abstract class Subject
    {
        List<Observer> _observers = new List<Observer>();
        public abstract string State { get; set; }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(State);
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        public override string State { get; set; }
    }
}