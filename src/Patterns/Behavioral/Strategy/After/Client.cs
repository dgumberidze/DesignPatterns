using Strategy.After.Factory;

namespace Strategy.After
{
    public class Client
    {
        private const string Filename = "after example image";

        public void Run()
        {
            IImageProcessingFactory factory = new ImageProcessingFactory();
            ICompressor compressor = factory.CreateCompressor(CompressorType.JPEG);
            IFilter filter = factory.CreateFilter(FilterType.HighContrast);

            ImageStorage imageStorage = new ImageStorage(compressor, filter);
            imageStorage.Store(Filename);

            imageStorage.Store(Filename,
                factory.CreateCompressor(CompressorType.PNG),
                factory.CreateFilter(FilterType.BlackAndWhite));
        }
    }
}
