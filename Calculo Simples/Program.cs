using static System.Console;
class DIO
{
 
    static void Main(string[] args) 
    {
		string[] input;

	    input = ReadLine().Split(' ');
        int cod1 = int.Parse(input[0]);
        int n1 = int.Parse(input[1]);
        double valor1 = double.Parse(input[2]);
        //Escreva sua lógica nos espaços em branco
 	    input = ReadLine().Split(' ');
        int cod2 = int.Parse(input[0]);
	    int n2  = int.Parse(input[1]);
        double valor2 = double.Parse(input[2]);

        WriteLine("VALOR A PAGAR: R$ {0:F}",(n1 * valor1) + (n2 * valor2));
    }

}