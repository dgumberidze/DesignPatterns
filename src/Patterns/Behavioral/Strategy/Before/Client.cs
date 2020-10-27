namespace Strategy.Before
{
    public class Client
    {
        private const string Filename = "before example image";

        public void Run()
        {
            ImageStorage imageStorage = new ImageStorage(CompressorType.PNG, FilterType.HighContrast);
            
            imageStorage.Store(Filename);

            //imageStorage.Store(Filename, CompressorType.JPEG, FilterType.BlackAndWhite);
        }
    }
}
