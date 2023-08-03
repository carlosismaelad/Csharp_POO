using System;
using System.Globalization;

namespace ProductDataExer
{
    class Program
    {
        static void Main(string[] args){

            Product p = new Product();


            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.InStock = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();


            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            p.AddToStock(quantity);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            p.RemoveFromStock(quantity);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
           




        }
    }
}
