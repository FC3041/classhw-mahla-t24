namespace P9;

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
    public static string day_of_the_week(int y,int m,int d)
    {
        int a=days_before_date(y,m,d);
        int b=a%7;
        string[] lis={"Wednesday","Thursday","Friday","Saturday","Sunday","Monday","Tuesday"};
        return lis[b];
    }
    static void Main(string[] args)
    {
        Console.WriteLine(day_of_the_week(2014,2,1));
    }
}
