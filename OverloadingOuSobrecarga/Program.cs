using System;
using System.Globalization;

namespace OverloadingOuSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /* 
            Não vamos mais pedir a quantidade porque temos um construtor que atribui valor padrão 0.
            Console.Write("Quantidade: ");
            int inStock = int.Parse(Console.ReadLine()); 
            */

            Product p = new Product(name, price);

            // sintaxe alternativa para instanciação de objetos:
            /* Product p3 = new Product
            {
                Name = "Laptop",
                Price = 2500.00,
                InStock = 20
            }; */


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
