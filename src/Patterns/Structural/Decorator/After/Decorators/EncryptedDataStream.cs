namespace Decorator.After.Decorators
{
    public class EncryptedDataStream : IDataStream
    {
        private readonly IDataStream _dataStream;

        public EncryptedDataStream(IDataStream dataStream)
        {
            _dataStream = dataStream;
        }

        public void Write(string data)
        {
            var encryptedData = Encrypt(data);
            _dataStream.Write(encryptedData);
        }


        private string Encrypt(string data)
        {
            return "@#$@#$#@#@!%$^&*%^";
        }

    }
}
