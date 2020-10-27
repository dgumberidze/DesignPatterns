using System;
using Strategy.After.Compressors;
using Strategy.After.Filters;

namespace Strategy.After.Factory
{
    public class ImageProcessingFactory : IImageProcessingFactory
    {
        public virtual ICompressor CreateCompressor(CompressorType compressorType = CompressorType.JPEG)
        {
            switch (compressorType)
            {
                case CompressorType.JPEG:
                    return new JPEGCompressor();
                case CompressorType.PNG:
                    return new PNGCompressor();
                default:
                    throw new ArgumentOutOfRangeException(nameof(compressorType));
            }
        }

        public virtual IFilter CreateFilter(FilterType filterType = FilterType.HighContrast)
        {
            return filterType switch
            {
                FilterType.HighContrast => new HighContrastFilter(),
                FilterType.BlackAndWhite => new BlackAndWhiteFilter(),
                _ => throw new ArgumentOutOfRangeException(nameof(filterType))
            };
        }
    }

    //public class NewImageProcessingFactory : ImageProcessingFactory
    //{
    //    public override ICompressor CreateCompressor(CompressorType compressorType = CompressorType.JPEG)
    //    {

    //        return base.CreateCompressor(compressorType);
    //    }
    //}
}
 