using System.Globalization;
namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args){

            /* 
            Calculator calc1 = new Calculator();
            Calculator calc2 = new Calculator(); 

            Comentamos a instanciação e agora a chamada será através do nome da própria classe 
            em vez da instância (double circ = calc.Circunference(raio);)
            */

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circunference(raio);
            double volume = Calculator.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
            

            
        }
        
    }
}