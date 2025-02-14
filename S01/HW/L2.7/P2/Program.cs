namespace P2;

class Program
{
    static long fac(int n)
    {
        long a=1;
        for (long i=1; i<(long)n+1; i++)
        {
            a*=i;
        }
        return a;
    }
    static void Main(string[] args)
    {
        for(int i=1; i<21; i++)
        {
            Console.WriteLine($"{i}:\t{fac(i)}");
        }   
    }
}
