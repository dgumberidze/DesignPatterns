using System;

namespace Strategy.After.Compressors
{
    public class JPEGCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"{fileName} compressed using JPEG compressor");
        }
    }
}