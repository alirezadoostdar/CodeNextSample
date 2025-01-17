public class program
{
    public string name { get; init; }
    public delegate void PrintDel(object text);
    public static PrintDel printt;
    public static void Main(string[] args)
    {
        Task<int> task = Task.Run(() =>
        {
            Console.WriteLine("Hello Task");
            return 3;
        });

        Task<int> task_1 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("hello task 1!");
            return 2;
        },TaskCreationOptions.LongRunning);
    }
 
}
