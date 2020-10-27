namespace Strategy.After.Factory
{
    public interface IImageProcessingFactory
    {
        ICompressor CreateCompressor(CompressorType compressorType);
        IFilter CreateFilter(FilterType filterType);
    }
}