namespace RocketshipFactored;

class Program
{
    static void Main(string[] args)
    {
        rocket();
    }
    static void cone()
    {
        Console.WriteLine("     ^");
        Console.WriteLine("    /|\\");
        Console.WriteLine("   //|\\\\");
        Console.WriteLine("  ///|\\\\\\");
    }
    static void tunk()
    {
        Console.WriteLine(" +-------+");
        Console.WriteLine(" +*******+");
        Console.WriteLine(" +*******+");
        Console.WriteLine(" +*******+");
        Console.WriteLine(" +*******+");
    }
    static void rocket()
    {
        cone();
        tunk();
        tunk();
        Console.WriteLine(" +-------+");
        cone();
    }
}
