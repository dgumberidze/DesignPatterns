using System;

namespace Strategy
{
    internal static class Program
    {

        private static void Main()
        {
            //Before.Client beforeClient = new Before.Client();
            //beforeClient.Run();

            After.Client afterClient = new After.Client();
            afterClient.Run();

            Console.ReadKey();
        }
    }
}
