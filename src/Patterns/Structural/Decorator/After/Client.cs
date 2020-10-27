using Decorator.After.Decorators;

namespace Decorator.After
{
    public class Client
    {
        private const string Data = "Data to store";

        public void Run()
        {

            StoreData(new DataStream());

            StoreData(new EncryptedDataStream(new DataStream()));
            
            StoreData(new CompressedDataStream(new DataStream()));
            
            StoreData(new EncryptedDataStream(new CompressedDataStream(new DataStream())));
        }

        public static void StoreData(IDataStream dataStream)
        {
            dataStream.Write(Data);
        }
    }
}
