namespace RocketshopLong;

class Program
{
    static void Main(string[] args)
    {
        cone();
        for(int i=0; i<4; i++)
        {
            tunk();
        }
        Console.WriteLine("+-------+");
        cone();
    }
    static void cone()
    {
        Console.WriteLine("    ^");
        for(int i=1; i<4; i++)
        {
            for(int j=0; j<(4-i); j++)
            {
                Console.Write(" ");
            }
            for(int j=0; j<i; j++)
            {
                Console.Write("/");
            }
            Console.Write("|");
            for(int j=0; j<i; j++)
            {
                Console.Write("\\");
            }
            Console.WriteLine("");
        }
    }
    static void tunk()
    {
        Console.WriteLine("+-------+");
        for(int i=0; i<6;i++)
        {
            Console.WriteLine("+*******+");
        }
    }
}
