using System;

namespace NullishbleCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;

            // se x tiver valor y receberá esse valor. Se x for nulo, y receberá 0.0 
            double y = x ?? 0.0;

            Console.WriteLine(y); // imprime 0.0

            double? a = null;
            double? b = 10;

            double c = a ?? 5.0; // se "a" não tiver valor c recebe 5.00
            double d = b ?? 5.0; // se "b" não tiver valor d recebe 5.00

            Console.WriteLine(c); // imprime 5 (valor padrão já que aé null)
            Console.WriteLine(d); // imprime 10
        }
    }
}
