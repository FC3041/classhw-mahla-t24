namespace P5;

class Program
{
    public static int fib(int n){
    int n1=1;
    int newn=1;
    for(int i=0; i<n-2;i++){
        int tem=newn;
        newn+=n1;
        n1=tem;
    }
    return newn;
    }
    static void Main(string[] args)
    {
        for(int i=1; i<21;i++)
        {
            Console.WriteLine($"{i}\t{fib(i)}");
        }
    }
}
