namespace P6;

class Program
{
    static void Main(string[] args)
    {
        ans(0,7,6);
    }
    static int delta(int a,int b,int c)
    {
        return (b*b)-4*a*c;
    }
    static void ans(int a,int b, int c)
    {
        int d=delta(a,b,c);
        if (a==0 && b!=0)
        {
            float x=(-(float)c)/(float)b;
            Console.Write($"{x:F2}");
        }
        else if(d<0 || (a==0 && b==0))
        {
            Console.Write("no answer");
        }
        else
        {
            if(d>0)
            {
                double x1=(-b+Math.Sqrt(d))/(2*a);
                double x2=(-b-Math.Sqrt(d))/(2*a);
                Console.Write($"{x1:F2} , {x2:F2}");
            }
            if(d==0)
            {
                Console.Write((-b)/(2*a));
            }
        }
    }
}
