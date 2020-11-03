using System;

namespace Adapter.After
{
    public class HighContrast : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying HighContrast filter");
        }
    }
}
