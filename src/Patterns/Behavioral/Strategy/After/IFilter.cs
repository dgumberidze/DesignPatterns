namespace Strategy.After
{
    public interface IFilter
    {
        //byte[] Compress(byte[] image);
        void Apply(string fileName);
    }
}