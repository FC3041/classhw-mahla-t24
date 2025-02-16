namespace P7_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"average_of_squares0(5): {average_of_squares0(5)}");
        Console.Write($"average_of_squares1(4): {average_of_squares1(4)}");
    }
    static float average_of_squares0(int n)
    {
        float sum=0;
        for(int i=0; i<n; i++)
        {
            sum+=(i*i);
        }
        return sum/n;
    }
    static float average_of_squares1(int n)
    {
        float sum=0;
        for(int i=1; i<n+1; i++)
        {
            sum+=(i*i);
        }
        return sum/n;
    }
}
