using System.Globalization;

namespace ProductDataExer
{
    public class Product
    {
        public string Name;
        public double Price;
        public int InStock;

        public double TotalValueInStock(){
            return Price * InStock;
        }


        public void AddToStock(int quantity){
            this.InStock += quantity;
        }

        public void RemoveFromStock(int quantity){
            this.InStock -= quantity;
        }

        public override string ToString()
        {
            return  Name 
                    + ", R$ " 
                    + Price.ToString("F2", CultureInfo.InvariantCulture) 
                    + ", " 
                    + InStock 
                    + " unidades, Total: R$ " 
                    + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
       
    }
}