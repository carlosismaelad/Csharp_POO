/* 
Ordem recomendada para implementação de classes:
1 - Atributos privados;
2 - Propriedades autoimplementadas;
3 - Construtores;
4 - Propriedades Customizadas;
5 - OUtros métodos da classe.
*/

using System.Globalization;

namespace Encapsulamento
{
    public class Account
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        public double Value { get; private set; }


        public Account(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public Account(int number, string name, double initialDeposit) : this(number, name)
        {
            Deposit(initialDeposit);
        }


        public void Deposit(double amount)
        {
            Value += amount;
        }

        public void Withdraw(double amount)
        {
            Value -= amount + 5.00;
        }

        public override string ToString()
        {
            return "Conta: "
                    + Number
                    + ", Titular: "
                    + Name
                    + ", Saldo: $: "
                    + Value.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}