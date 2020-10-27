using System;

namespace Strategy.After.Filters
{
    public class HighContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"{fileName} filtered using high contrast filter");
        }
    }
}