using System;

// ReSharper disable once InvalidXmlDocComment
/// <summary>
/// პრობლემები
/// 1. არღვევს SingleResponsibility პრინციპს. ეს კლასი პასუხისმგებელი უნდა იყოს მხოლოდ შენახვაზე
/// 2. არღვევს OpenClose პრინციპს, რადგან ახალი კომპრესორის ან ფილტრის ტიპის დამატების შემთხვევაში მოგვიწევს ProcessImage მეთოდის გადაკეთება
/// </summary>

namespace Strategy.Before
{


    public class ImageStorage
    {
        private readonly CompressorType _compressor;
        private readonly FilterType _filter;

        public ImageStorage(CompressorType compressor, FilterType filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void Store(string fileName)
        {
            ProcessImage(fileName, _compressor, _filter);
            SaveImage(fileName);
        }

        public void Store(string fileName, CompressorType compressor, FilterType filter)
        {
            ProcessImage(fileName, compressor, filter);
            SaveImage(fileName);
        }

        private void ProcessImage(string fileName, CompressorType compressorType, FilterType filterType)
        {
            if (compressorType == CompressorType.JPEG)
            {
                Console.WriteLine($"{fileName} compressed using JPEG compressor");
            }
            else if (compressorType == CompressorType.PNG)
            {
                Console.WriteLine($"{fileName} compressed using PNG compressor");
            }


            if (filterType == FilterType.BlackAndWhite)
            {
                Console.WriteLine($"{fileName} filtered using B&W filter");
            }
            else if (filterType == FilterType.HighContrast)
            {
                Console.WriteLine($"{fileName} filtered using high contrast filter");
            }
        }

        private void SaveImage(string filename)
        {
            Console.WriteLine($"{filename} saved");
        }
    }
}
