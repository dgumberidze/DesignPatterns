using Adapter.ThirdPartyFilters;

namespace Adapter.Before
{
    public class Client
    {
        public void Run()
        {

            ImageView imageView = new ImageView(new Image());
            imageView.Apply(new HighContrast());

            //imageView.Apply(new BlackAndWhite()); //Compile error!!!
        }
    }
}
