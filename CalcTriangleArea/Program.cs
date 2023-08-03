using System.Globalization;

namespace IntroAClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();
            

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcArea();
            double areaY = y.CalcArea();

            Console.WriteLine("Áre do triângulo X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Áre do triângulo Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY ){
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }
            

        }
    }
}