using static System.Console; 
using System;

class minhaClasse 
{

    static void Main(string[] args) 
    { 

            double a, b, c, delta, r1, r2;
            string[] valor = ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            
            
            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            var t1 = r1.ToString("N5");
            var t2 = r2.ToString("N5");

            if (a != 0 && delta > 0)
            {
              WriteLine("R1 = "+t1);
              WriteLine("R2 = "+t2);
              
            }
            else
            {
                WriteLine("Impossivel calcular");
            }

    }

}
