namespace p1;

class Program
{
    public static int fac(int n)
    {
        int a=1;
        if(n>0){                     //preconditon
            for(int i=1;i<n+1;i++)
            {
                a=a*i;
            }
        }
        else{
            return -1;
        }
        if (a>0){                    //postcondition
            return a;
        }
        else{
            return -1;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(fac(-5));
    }
}
