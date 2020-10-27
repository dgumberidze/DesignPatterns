namespace Strategy.After
{
    public interface ICompressor
    {
        //byte[] Compress(byte[] image);
        void Compress(string fileName);
    }
}