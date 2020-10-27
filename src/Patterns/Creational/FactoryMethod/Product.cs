using System;

namespace FactoryMethod
{
    public abstract class Product
    {        
    }

    public class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine("Product created");
        }
    }
}
