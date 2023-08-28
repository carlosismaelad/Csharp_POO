using System;
using System.Globalization;

namespace Vetores_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe quantas medidas serão inseridas");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            double accum = 0.0;

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write($"Informe a medida {i + 1}: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                accum += vect[i];
            }

            double avg = accum / vect.Length;

            Console.WriteLine($"A média das alturas é {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
