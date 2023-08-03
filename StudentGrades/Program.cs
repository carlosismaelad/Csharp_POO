using System.Globalization;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args){

            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            student.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Nota final: " + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            
            if (student.Aproved()){
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " 
                                    + student.MissingNote().ToString("F2", CultureInfo.InvariantCulture)
                                    + " pontos");
            }

        }
    }
}
