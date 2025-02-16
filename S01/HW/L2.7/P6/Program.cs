namespace P6;

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
    static void Main(string[] args)
    {
        Console.WriteLine(days_in_month(2));
    }
}
