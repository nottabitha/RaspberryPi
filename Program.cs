using BlinkTutorial;
class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hello World");

        await Blink.BlinkMillisecond(1000,18);
    }
    
}




