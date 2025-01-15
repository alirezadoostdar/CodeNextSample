public class program
{
    const string path = @"D:\OneDrive\System Design\CodeNextSample\Concurruncy2\Index.txt";
    static object _lock = new object();
    public static void Main(string[] args)
    {
        new Thread(SaveFile).Start();

        void SaveFile()
        {
            Monitor.Enter(_lock);
            try
            {
                File.AppendAllText(path, "example Text");
            }
            finally
            {
                Monitor.Exit(_lock);
            }
    
        }
    }
}
