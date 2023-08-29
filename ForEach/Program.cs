using System;

namespace ForEach
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "André", "Marcelo", "Paulo" };

            foreach (string nome in vect)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
