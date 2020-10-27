namespace FactoryMethod
{
    public abstract class Creator
    {
        public abstract Product CreateProduct(); // Factory method
    }

    public class ConcreteCreator : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProduct();
        }
    }
}