namespace P6;
class Program
{
    public static void py(int n)
    {
        for(int i=1; i<n; i++)
        {
            for(int j=1; j<n; j++)
            {
                int a=(i*i)+(j*j);
                double sqrt_a=Math.Sqrt(a);
                if((Math.IEEERemainder(sqrt_a,1)==0) && (sqrt_a<n))
                {
                    Console.WriteLine($"A: {i}\tB: {j}\tC: {sqrt_a}");
                }
            }
        }
    }
    static void Main(string[] args)
    {
        py(30);
    }
}
