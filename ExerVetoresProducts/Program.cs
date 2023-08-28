using System;
using System.Globalization;

namespace ExerVetoresProducts
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos que serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            double sum = 0.0;

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write($"Nome do produto {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Preço do produto {i + 1}: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
                sum += vect[i].Price;
            }

            double averagePrice = sum / vect.Length;
            Console.WriteLine($"Preço médio dos produtos: ${averagePrice.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}


