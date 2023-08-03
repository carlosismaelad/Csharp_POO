using System.Globalization;

namespace ExerClassesAverageSalaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1, emp2;
            emp1 = new Employee();
            emp2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            emp1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            emp1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            emp2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            emp2.Salary = double.Parse(Console.ReadLine());

            double avgSalary = Employee.CalcAverageSalary(emp1, emp2);
            Console.WriteLine("A média salarial dos funcionários é: R$" + avgSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}