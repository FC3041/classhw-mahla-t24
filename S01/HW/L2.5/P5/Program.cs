namespace P5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(power(2,10));
    }
    static int power(int x, int y)
    {
        int a=1;
        if(y>=0)
        {
            for(int i=0; i<y ; i++)
            {
                a*=x;
            }
        }
        return a;
    }
}
