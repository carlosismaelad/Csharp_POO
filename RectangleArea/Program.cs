using System.Globalization;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args){

            Rectangle rec = new Rectangle();
            
            Console.WriteLine("Entre com os dados do retângulo: ");
            Console.Write("Altura: ");
            rec.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            rec.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Área:" + rec.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro:" + rec.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal:" + rec.Diagonal().ToString("F2", CultureInfo.InvariantCulture));       




        }
    }
}
