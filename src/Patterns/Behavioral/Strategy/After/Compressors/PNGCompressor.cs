using System;

namespace Strategy.After.Compressors
{
    public class PNGCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"{fileName} compressed using PNG compressor");
        }
    }
}