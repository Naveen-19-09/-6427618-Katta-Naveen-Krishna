using System;
public class Logger
{
    private static readonly Logger _instance = new Logger();
    private Logger()
    {
        Console.WriteLine("Logger Initialized");
    }
    public static Logger Instance
    {
        get
        {
            return _instance;
        }
    }
    public void Log(string message)
    {
        Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        logger1.Log("Application started.");
        Logger logger2 = Logger.Instance;
        logger2.Log("Processing request...");
        Console.WriteLine(Object.ReferenceEquals(logger1, logger2));
    }
}