namespace Adapter.Structure
{
    public class Client
    {
        public static void ClientMain()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}