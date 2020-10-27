using System;

namespace OOPTechnique
{
    public class Factory
    {
        public Product CreateProduct() //FactoryMethod
        {
            return new Product();
        }
    }

    public class Product
    {
        public Product()
        {
            Console.WriteLine("New Product created!");
        }
    }


    public class Client
    {
        public static void Main()
        {
            Factory factory = new Factory();

            Product product = factory.CreateProduct();
        }
    }
}
