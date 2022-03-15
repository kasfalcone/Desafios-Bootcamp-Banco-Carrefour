using static System.Console;
using System;

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int N = int.Parse(ReadLine());
            int p = 1;
            int[] array = new int[3];

            for (int i = 1; i <= N; i++) 
            {
              for(int j=1; j<=3; j++)
              {          
                array[j-1] = p++;
              }
            p++;
            
            WriteLine(String.Join(" ", array)+" PUM");
                
            }
        }
    }
}
