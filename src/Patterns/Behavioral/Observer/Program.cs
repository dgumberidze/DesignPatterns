namespace Observer
{
    static class Program
    {
        static void Main(string[] args)
        {
            PushValue.Client pushValueClient = new PushValue.Client();
            pushValueClient.Run();

            PullValue.Client pullValueClient = new PullValue.Client();
            pullValueClient.Run();
        }
    }
}
