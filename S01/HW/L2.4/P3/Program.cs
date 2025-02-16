namespace P3;

class Program
{
    static void Main(string[] args)
    {
        print_right_triangle(20);
    }

    static void print_right_triangle(int n)
    {
        for(int i=1; i<n+1; i++)
        {
            for(int j=0; j<(n-i);j++)
            {
                Console.Write(" ");
            }
            for (int j=0; j<i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
