namespace p7;

class Program
{
    public static double e(double x, double p){
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



    public static double ln(int x, double pre)
    {
        double left=0;
        double right=x;
        double mid=0;
        while(right-left>=pre)
        {
            mid=(right+left)/2;
            if( x> e(mid,0.00001) ){
                left=mid;
            }else{
                right=mid;
            }
        }
        return mid;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"p7:  ln20: {ln(20, 0.0001):f5}");
    }
}
