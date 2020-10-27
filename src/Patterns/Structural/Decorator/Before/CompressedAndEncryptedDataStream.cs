namespace Decorator.Before
{
    public class CompressedAndEncryptedDataStream : DataStream
    {
        public override void Write(string data)
        {
            var encryptedData = Encrypt(data);
            var compressedData = Compress(encryptedData);
            base.Write(compressedData);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }

        private string Encrypt(string data)
        {
            return "@#$@#$#@#@!%$^&*%^";
        }
    }
}
