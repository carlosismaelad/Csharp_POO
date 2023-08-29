using System;
using System.Collections.Generic; // Precisa desta importação

namespace ListasI
{
    class Program
    {
        public static void Main(string[] args)
        {

            // instanciando uma nova lista
            List<string> lista1 = new List<string>();

            // podemos instanciar uma lista já com elementos nela
            Listas<string> lista2 = new List<string> { "Alex", "Maria", "Ana", "João" };
        }
    }
}