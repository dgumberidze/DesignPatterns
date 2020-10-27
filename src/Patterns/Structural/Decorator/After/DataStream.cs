using System;

namespace Decorator.After
{
    public class DataStream : IDataStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}