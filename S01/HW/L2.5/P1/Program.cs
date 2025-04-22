namespace P1;

class Program
{
    static void Main(string[] args)
    {
        FtoC(41);
    }
    static void FtoC(float f)
    {
        float c;
        float x= (float)5 / (float)9;
        c=(f-32)*x;
        Console.WriteLine($"Fahrenheit:\t{f:F2}");
        Console.Write($" Celsius:\t{c:F2}");
    }
}
