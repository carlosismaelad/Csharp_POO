using System.Globalization;

namespace OverloadingOuSobrecarga
{
    public class Product
    {
        public string Name;
        public double Price;
        public int InStock;

        public Product(string name, double price, int inStock)
        {
            Name = name;
            Price = price;
            InStock = inStock;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
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