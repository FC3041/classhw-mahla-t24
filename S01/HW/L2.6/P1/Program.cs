namespace P1;

class Program
{
    static void Main(string[] args)
    {
        int[] st={1792,1796,1800,1804,1900,1904,2000,2004};
        for(int i=0; i<8; i++)
        {
            if(leapyear(st[i]))
            {
                Console.WriteLine($"{st[i]}\t:true");
            }
            else
            {
                Console.WriteLine($"{st[i]}\t:false");
            }
        }
    }
    public static bool leapyear(int n)
    {
        if(n%400==0)
            return true;
        if(n%4==0  &&  n%100!=0)
            return true;
        return false;
    }
}
