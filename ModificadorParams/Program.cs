using System;

namespace ModificadorParams
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Usando os métodos de sobrecarga (muito ruim)
            int s1 = Calculator.Sum(2, 5);
            int s2 = Calculator.Sum(2, 5, 3);
            int s3 = Calculator.Sum(2, 5, 3, 4);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3); */

            /* Usando o método com vetor. É preciso fazer a instanciação de um novo vetor tornando o código mais verboso.
            int s1 = Calculator.Sum(new int[] { 2, 5 });
            int s2 = Calculator.Sum(new int[] { 2, 5, 3 });
            Console.WriteLine(s1);
            Console.WriteLine(s2); */

            // Usando o método com modificador de parâmetros "params"
            int s1 = Calculator.Sum(2, 5);
            int s2 = Calculator.Sum(2, 5, 3, 10, 200, 15);
            Console.WriteLine(s1);
            Console.WriteLine(s2);




        }
    }
}