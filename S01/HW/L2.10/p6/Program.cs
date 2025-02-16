namespace p6;

class Program
{


    public static double power(double x , int y)
    {       
        double a=1;
        if(y>=0)
        {
            for(int i=0; i<y;i++)
            {
                a=a*x;
            }
        }
        return a;
    }

    public static double nth_root(int x,int y, double pre)
    {
        double left=0;
        double right=x;
        double mid=0;

        while(right-left > pre){
            mid=(right+left)/2;
            if(x>(power(mid,y))){
                left=mid;
            }else{
                right=mid;
            }
        }
        return mid;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"p6:  the 3th root of 8:  {nth_root(8,3,0.000001):f5}");
    }
}
