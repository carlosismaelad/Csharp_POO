using System.Globalization;

namespace Constructor
{
    public class Product
    {
        public string Name;
        public double Price;
        public int InStock;

        public Product(string name, double price, int inStock)
        {
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
        }

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