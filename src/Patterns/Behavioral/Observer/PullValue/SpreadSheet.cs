using System;

namespace Observer.PullValue
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"SpreadSheet notified: {_dataSource.Value}");
        }
    }
}
