using System;

namespace Strategy.After
{
    // კონტექსტი
    public class ImageStorage
    {
        private readonly ICompressor _compressor;
        private readonly IFilter _filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }
        
        public void Store(string fileName)
        {
            ProcessImage(fileName, _compressor, _filter);
            SaveImage(fileName);
        }

        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            ProcessImage(fileName, compressor, filter);
            SaveImage(fileName);
        }

        private void ProcessImage(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }

        private void SaveImage(string filename)
        {
            Console.WriteLine($"{filename} saved");
        }
    }
}
