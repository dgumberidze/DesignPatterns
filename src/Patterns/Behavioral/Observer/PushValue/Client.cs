namespace Observer.PushValue
{
    public class Client
    {
        public void Run()
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart1 = new Chart();
            var chart2 = new Chart();

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart1);
            dataSource.AddObserver(chart2);

            dataSource.Value = 5;

        }
    }
}
