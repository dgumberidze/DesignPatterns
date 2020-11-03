namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before.Client beforeClient = new Before.Client();
            //beforeClient.Run();

            After.Client afterClient = new After.Client();
            afterClient.Run();
        }
    }
}
