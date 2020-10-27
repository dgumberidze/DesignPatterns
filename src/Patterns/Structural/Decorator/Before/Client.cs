namespace Decorator.Before
{
    public class Client
    {
        private const string Data = "123 456 789 123";

        public void Run()
        {
            
            DataStream dataStream = new DataStream();
            dataStream.Write(Data);

            dataStream = new EncryptedDataStream();
            dataStream.Write(Data);

            dataStream = new CompressedDataStream();
            dataStream.Write(Data);

            dataStream = new CompressedAndEncryptedDataStream();
            dataStream.Write(Data);
        }
    }
}
