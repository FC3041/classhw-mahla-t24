namespace p6;

class Program
{
    public static void compute_change(int n)
    {
        int newn=100-n;
        int q=0,d=0,ni=0,p=0;
        while(newn>=25)
        {
            newn-=25;
            q++;
        }
        while(newn>=10)
        {
            newn-=10;
            d++;
        }      
        while(newn>=5)
        {
            newn-=5;
            ni++;
        }
        while(newn>=1)
        {
            newn-=1;
            p++;
        }
        Console.WriteLine($"{q} qauarters");
        Console.WriteLine($"{d} dime");
        Console.WriteLine($"{ni} nickel");
        Console.WriteLine($"{p} pennies");
    }
    static void Main(string[] args)
    {
        compute_change(8);
    }
}
