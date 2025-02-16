namespace P1;

class Program
{
    public static int absolute_value(int x)
    {
        if(x>0){
            return x;
        }
        if(x<0){
            return -x;
        }
        return 0;
    }
        
    static void Main(string[] args)
    {
        Console.WriteLine(absolute_value(-100));
        Console.WriteLine(absolute_value(-1));
        Console.WriteLine(absolute_value(0));
        Console.WriteLine(absolute_value(1));
        Console.WriteLine(absolute_value(1000));
    }
}
