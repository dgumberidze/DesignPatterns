using Adapter.ThirdPartyFilters;

namespace Adapter.After
{
    public class BlackAndWhiteFilter : IFilter
    {

        private readonly BlackAndWhite _blackAndWhite;

        public BlackAndWhiteFilter(BlackAndWhite blackAndWhite)
        {
            _blackAndWhite = blackAndWhite;
        }

        public void Apply(Image image)
        {
            _blackAndWhite.Init();
            _blackAndWhite.Render(image);
        }
    }
}
