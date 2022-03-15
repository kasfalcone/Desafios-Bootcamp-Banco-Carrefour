using static System.Console;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            A = double.Parse(ReadLine());
            B = double.Parse(ReadLine());
            C = double.Parse(ReadLine());
            MEDIA = ((A*2) + (B*3) + (C*5))/10;
            var format = MEDIA.ToString("F1");
            WriteLine("MEDIA = "+format);
            ReadKey();
        }
    }
}