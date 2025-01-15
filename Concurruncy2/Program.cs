public class program
{
    const string path = @"D:\OneDrive\System Design\CodeNextSample\Concurruncy2\Index.txt";
    static object _lock = new object();
    public static void Main(string[] args)
    {
        new Thread(SaveFile).Start();

        void SaveFile()
        {
            lock (_lock)
            {
                File.AppendAllText(path, "example Text");
            }
            //Monitor.Enter(_lock);
            //try
            //{
            //    
            //}
            //finally
            //{
            //    Monitor.Exit(_lock);
            //}
        }
    }
}
