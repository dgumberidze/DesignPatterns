namespace Decorator.After.Decorators
{
    public class CompressedDataStream : IDataStream
    {
        private readonly IDataStream _dataStream;

        public CompressedDataStream(IDataStream dataStream)
        {
            _dataStream = dataStream;
        }

        public void Write(string data)
        {
            var compressedData = Compress(data);
            _dataStream.Write(compressedData);
        }


        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }

    }
}