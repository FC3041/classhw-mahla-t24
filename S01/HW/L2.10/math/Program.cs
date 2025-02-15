namespace math;

class Program
{
    public static double fac(double n)
    {
        double a=1;
        for(int i=1;i<n+1;i++)
        {
            a=a*i;
        }
        return a;
    }

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

    public static double e(float d){
        double e=1;
        double n=0;
        while(true){
            n++;
            if((1/fac(n))<d){
                break;
            }
            e+=(1/fac(n));
        }
        return e;
    }

    public static double exper(int x, double p){
        double n=0;
        double e=1;
        while(true){
            n++;
            if ((power(x,(int)n)/fac(n))<p){
                break;
            }    
            e+=(power(x,(int)n)/fac(n));
        }
        return e;
    }

    public static double pi(){
        double n=1;
        int cou=1;
        double ans=0;
        while(true){
            if((4/n)<0.0000001){
                break;
            }
            ans+=(4/n)*(cou);
            cou*=-1;
            n+=2;
        }
        return ans;
    }

    public static double sino(double x,double pre){
        x=(x*pi())/180;
        int n=1; 
        int cou=1;
        double sin=0;
        while(true){
            if((power(x,n)/fac(n))<pre){
                break;
            }
            sin+=(power(x,n)/fac(n))*(cou);
            n+=2;
            cou*=-1;
        }
        return sin;
    }

    public static void square_root(int x, double pre)
    {
        double left=0;
        double right=x;
        double mid=0;
        int iter=0;

        while(right-left > pre){
            mid=(right+left)/2;
            if(x>(mid)*(mid)){
                left=mid;
            }else{
                right=mid;
            }
            iter++;
        }
        Console.WriteLine($"p5:   squar root{x}: {mid:f5}    iterations: {iter}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"p1: {e(0.001f):f5}");
        Console.WriteLine($"p2: {exper(1,0.001):f5} ____ {exper(2,0.001):f5}");
        Console.WriteLine($"p4:  45-> {sino(45,0.001):f5}  90-> {sino(90,0.00000001):f5}  0-> {sino(0,0.001):f5}");
        square_root(2,0.000001);

    }
}
