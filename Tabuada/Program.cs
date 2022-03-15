using static System.Console;
using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());

            for (int i = 1; i < 11; i++)
            {
                WriteLine(string.Format($"{i} x {n} = {i*n}")); //escreva o seu código nos espaços em branco
            }
        }
    }
}