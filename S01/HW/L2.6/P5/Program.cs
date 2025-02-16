namespace P5;

class Program
{
    public static void print_month(int m)
    {
    if (m==1){
        Console.Write("Jan");}
    if (m==2){
        Console.Write("Feb");}
    if (m==3){
        Console.Write("mar");}
    if (m==4){
        Console.Write("Apr");}
    if (m==5){
        Console.Write("may");}
    if (m==6){
        Console.Write("Jun");}
    if (m==7){
        Console.Write("Jul");}
    if (m==8){
        Console.Write("Aug");}
    if (m==9){
        Console.Write("Sep");}
    if (m==10){
        Console.Write("Oct");}
    if (m==11){
        Console.Write("Nov");}
    if (m==12){
        Console.Write("Dec");}
    }
    static void Main(string[] args)
    {
        for(int i=1; i<13; i++)
        {
            Console.Write($"{i}: \t");
            print_month(i);
            Console.WriteLine();
        }
    }
}
