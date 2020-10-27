namespace FactoryMethod
{
    public class Client
    {
        public static void ClientMain()
        {
            Creator creator = new ConcreteCreator();
            Product product = creator.CreateProduct(); 
        }
    }
}
