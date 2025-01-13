public class Singletons
{
    // Step 1: Create a private static variable to hold the single instance
    private static Singletons _instance;

    // Step 2: Create a private static object for locking
    private static readonly object _lock = new object();

    // Step 3: Make the constructor private to prevent external instantiation
    private Singletons()
    {
        Console.WriteLine("Singleton instance created.");
    }
    
    // Step 4: Provide a public static method to access the instance
    public static Singletons Instance
    {
        get
        {
            // Double-check locking mechanism for thread safety
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singletons();
                    }
                }
            }

            return _instance;
        }
    }

    // Step 5: Add a method to demonstrate functionality
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"Singleton says: {message}");
    }
}

