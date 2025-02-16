namespace P8;

class Program
{
    public static int days_in_month(int m){
        if(m==2){
            return 28;
        }
        if(m==1 || m==3 || m==5 || m==7 || m==8 || m==10 || m==12){
            return 31;
        }
        else{
            return 30;
        }
    }
    public static int days_before_date(int y,int m, int d){
        int ans=0;
        while(d!=0){
            d--;
            ans++;
        }
        ans--;
        m--;
        while(m!=0){
            ans+=days_in_month(m);
            m--;
        }
        return ans;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(days_before_date(2014,12,31));
        Console.WriteLine(days_before_date(2014,1,1));

    }
}
