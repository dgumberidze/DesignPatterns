using System;

namespace Strategy.After.Filters
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"{fileName} filtered using B&W filter");
        }
    }
}