using static System.Console;
using System;

class Pneu 
{
    static void Main () 
    {
        var A = int.Parse(ReadLine());
        var B = int.Parse(ReadLine());
        int total = A-B;
        WriteLine(total);
    }
}