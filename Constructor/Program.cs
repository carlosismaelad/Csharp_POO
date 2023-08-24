using System.Globalization;

namespace Constructor
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
            Console.Write("Quantidade: ");
            int inStock = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, inStock);

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