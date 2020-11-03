using System;

namespace Observer.PushValue
{
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"SpreadSheet notified: {value}");
        }
    }
}