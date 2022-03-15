using static System.Console;
using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());


            for (int i = 1; i <= n; i++)
            {
                
              WriteLine($"{i} {i*i} {i*i*i}");
                
            }
            
        }
    }
}