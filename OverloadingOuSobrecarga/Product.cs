using System.Globalization;

namespace OverloadingOuSobrecarga
{
    public class Product
    {
        public string Name;
        public double Price;
        public int InStock;

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /* 
        Se declararmos os parâmetro do construtor iguais aos atributos da classe devemos usar o .this para que o compilador saiba o que é parâmetro
        e o que é atributo. Usamos o this, também, quando queremos referenciar um 
        construtor dentro de outro construtor. EX:

        public Product()
        {
            InStock = 0;
        }

        public Product(string Name, double Price) : this()
        {
            this.Name = Name;
            this.Price = Price;

        } 
        */

        public double TotalValueInStock()
        {
            return Price * InStock;
        }

        public void AddToStock(int quantity)
        {
            this.InStock += quantity;
        }

        public void RemoveFromStock(int quantity)
        {
            this.InStock -= quantity;
        }

        public override string ToString()
        {
            return Name
                    + ", R$ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + InStock
                    + " unidades, Total: R$ "
                    + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}