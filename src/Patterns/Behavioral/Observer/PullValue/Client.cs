namespace Observer.PullValue
{
    public class Client
    {
        public void Run()
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart1 = new Chart(dataSource);
            var chart2 = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart1);
            dataSource.AddObserver(chart2);

            dataSource.Value = 5;

        }
    }
}
