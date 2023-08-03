using System;

namespace ExerClassesIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Age = int.Parse(Console.ReadLine());

            string olderPersonName = Person.CompareAges(p1, p2);

            Console.WriteLine(olderPersonName);


        }
    }

}

