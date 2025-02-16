namespace p3A;

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
    static void Main(string[] args)
    {
        if(near(1000,1002,0.001)){
        Console.WriteLine("True");
        }
        else{
        Console.WriteLine("False");
        }
    }
}
