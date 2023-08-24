using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc;

            Console.Write("Entre com o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string name = Console.ReadLine();
            Console.Write("Haverá deposíto inicial? (Y/N): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'y' || resp == 'Y') // if (resp.ToString().Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc = new Account(number, name, initialDeposit);
            }
            else
            {
                acc = new Account(number, name);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre com o valor para depósito: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.Deposit(amount);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.Withdraw(amount);

            Console.WriteLine();
            Console.WriteLine("Taxa referente a saque: $5.00 ");

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(acc);


        }
    }
}
