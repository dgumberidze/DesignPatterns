using System;

namespace Adapter.Before
{
    public class HighContrast : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying HighContrast filter");
        }
    }
}
