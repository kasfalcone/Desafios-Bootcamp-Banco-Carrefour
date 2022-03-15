using static System.Console;
using System; 

class Poligonos 
{

    static void Main(string[] args) 
    { 

        string[] v = ReadLine().Split();
        

        int val1 = int.Parse(v[0]);
        int val2 = int.Parse(v[1]);

            
        WriteLine($"{val2 * val1} ");

    }

}

