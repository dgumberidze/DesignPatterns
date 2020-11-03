using System;

namespace Adapter.ThirdPartyFilters
{
    public class BlackAndWhite
    {
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("Appliyng BlackAndWhite filter");
        }
    }
}
