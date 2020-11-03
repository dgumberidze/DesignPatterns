using System;

namespace Observer.PullValue
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Chart notified: {_dataSource.Value}");
        }
    }
}