namespace Observer.Structure.PushModel
{
    public abstract class Observer
    {
        public abstract void Update(string state);
    }

    public class ConcreteObserver : Observer
    {
        private string _observerState;
        public override void Update(string state)
        {
            _observerState = state;
        }
    }
}