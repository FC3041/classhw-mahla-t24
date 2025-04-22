namespace P3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(fac(5));
    }
    static int fac(int n)
    {
        int a=1;
        for (int i=1; i<n+1; i++)
        {
            a*=i;
        }
        return a;
    }
}
