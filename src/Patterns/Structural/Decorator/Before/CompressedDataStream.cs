namespace Decorator.Before
{
    public class CompressedDataStream : DataStream
    {
        public override void Write(string data)
        {
            var compressedData = Compress(data);
            base.Write(compressedData);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}