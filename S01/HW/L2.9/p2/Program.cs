namespace p2;

class Program
{
    public static bool is_divisible(int a, int b)
    {
        if (a%b==0){
            return true;
        }
        return false;
}

public static bool is_prime(int n)
{
    if(n>0){              //precondition
        if(n==2){
            return true;
        }
        if(n==4){
            return false;
        }
        for(int i=3; i<n;i++){
            if(is_divisible(n,i)){
                return false;
            }
        }
        return true;
    }
    else{
        return false;
    }
}
    static void Main(string[] args)
    {
        for(int i=1;i<100; i++){
            if(is_prime(i)){
                Console.WriteLine(i);
            }
        }
    }
}
