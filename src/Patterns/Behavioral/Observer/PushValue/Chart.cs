using System;

namespace Observer.PushValue
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"Chart notified: {value}");
        }
    }
}