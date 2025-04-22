namespace p3;

class Program
{
    public static double exper(int x, float p){
    double n=1;
    double e=1+x;
    double newa=x/n;
    while(true){
        n++;
        newa*=x/n;
        if (newa<p){
            break;
        }    
        e+=newa;
    }
    return e;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"p3: {exper(2,0.0001f)}");
    }
}
