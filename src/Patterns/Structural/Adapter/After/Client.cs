using Adapter.ThirdPartyFilters;

namespace Adapter.After
{
    public class Client
    {
        public void Run()
        {
            ImageView imageView = new ImageView(new Image());
            imageView.Apply(new HighContrast());
            imageView.Apply(new BlackAndWhiteFilter(new BlackAndWhite()));
        }
    }
}
