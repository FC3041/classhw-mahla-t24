namespace P4;

class Program
{
    public static void print_cone(int n)
    {
        for(int i=0; i<n ; i++)
        {
            Console.Write(" ");
        }
        Console.Write("^");
        Console.WriteLine();
        for(int i=1;i<n;i++)
        {
            for(int j=0; j<(n-i);j++)
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
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        for(int i=0; i<10; i++)
        {
            if(i%2!=0)
            {
                print_cone(i);
                Console.WriteLine();
            }
        }
    }
}
