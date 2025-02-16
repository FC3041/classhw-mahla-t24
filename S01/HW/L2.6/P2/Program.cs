namespace P2;

class Program
{
    public static void triangle(int n)
    {
        for(int i=0; i<n;i++)
        {
            if(i%2==0)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                for(int j=0; j<i;j++)
                {
                    Console.Write("%");
                }
                Console.WriteLine();
            }

        }
    }
    static void Main(string[] args)
    {
        triangle(20);
    }
}
