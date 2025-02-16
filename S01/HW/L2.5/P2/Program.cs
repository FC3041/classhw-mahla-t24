namespace P2;

class Program
{
    static void Main(string[] args)
    {
        CtoF(121);
    }
    static void CtoF(float c)
    {
        float f;
        f=((float)(1.8)*c)+32;
        Console.WriteLine($"Celsius:\t{c:F2}");
        Console.Write($"Fahrenheit:\t{f:F2}");
    }
}
