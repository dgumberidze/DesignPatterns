using System;

namespace Decorator.Before
{
    public class DataStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}