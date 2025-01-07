namespace ConcurrencyAndAsynchrony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new(WriteT);
            t.Start();
            t.Join();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("M ");
            }
            
        }


        static void WriteT()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("T ");
            }
        }
    }

    
}
