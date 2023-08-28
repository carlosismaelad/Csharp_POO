using System;
using System.Globalization;

namespace ExerVetoresPensionato
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rent[] rooms = new Rent[10];

            Console.Write("How many rooms are be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());
                rooms[roomNumber] = new Rent(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Room {i}: {rooms[i]}");
                }
            }








        }
    }
}



