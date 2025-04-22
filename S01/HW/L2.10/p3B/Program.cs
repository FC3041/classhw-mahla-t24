namespace p3B;

class Program
{
    public static double absel(double x){
    if(x>0){
        return x;
    }
    if (x<0){
        return -x;
    }
    return 0;
}

    public static bool near(double x, double y, double clo){
        x=absel(x);
        y=absel(y);
        double d;
        if(x>y){
            d=clo*x;
            if((x-y)>d){
                return false;
            }
            return true;
        }
        else{
            d=clo*y;
            if((y-x)>d){
                return false;
            }
            return true;
        }
    }

    public static double exper2(int x, float p){
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

    public static double exper1(int x, float p){
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
    static void Main(string[] args)
    {
        if(near(exper1(2,0.001f),exper2(2,0.001f),0.000001)){
        Console.WriteLine("True");
        }
        else{
        Console.WriteLine("False");
        }
    }
}
