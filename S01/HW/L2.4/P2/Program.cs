﻿namespace P2;

class Program
{
    static void Main(string[] args)
    {
        print_left_triangle(20, '%');
    }

    static void print_left_triangle(int n, char x)
    {
        for(int i=1;i<n+1; i++)
        {
            for(int j=0; j<i; j++)
            {
                Console.Write(x);
            }
            Console.WriteLine("");
        }
    }
}
