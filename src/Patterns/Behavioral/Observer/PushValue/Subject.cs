using System.Collections.Generic;

namespace Observer.PushValue
{
    //Observable
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(int value)
        {
            foreach (var observer in _observers)
            {
                observer.Update(value);
            }
        }
    }
}
