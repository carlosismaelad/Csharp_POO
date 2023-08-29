using System;
using System.Collections.Generic; // Precisa desta importação

namespace Listas
{
    class Program
    {
        public static void Main(string[] args)
        {

            // instanciando uma nova lista
            List<string> list = new List<string>();

            /* 
            Podemos instanciar uma lista já com elementos nela
            Listas<string> lista = new List<string> { "Alex", "Maria", "Ana", "João" }; 
             
            Podemos criar uma lista que recebe uma lista de objetos:
            lista.Add(new Product()) 
            */


            // Adicionando elementos à lista (o Add sempre adiciona os demais elementos ao final da lista):
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Marco");
            list.Add("Anders");

            // Adicionando com o Insert (o Insert permite especificar a posição onde queremos adicionar o elemento):
            list.Insert(0, "Carlos");
            list.Insert(2, "Eduardo");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            /* 
            imprime:
            Carlos
            Maria
            Eduardo
            Alex
            Bob
            Marco
            Anders
             */


            // Obter o tamanho da lista:
            Console.WriteLine($"Tamanho da lista: {list.Count}");
            // => Tamanho da lista: 7


            // Encontrar primeiro ou último elementos da lista que satisfaça um predicado usando uma função que criamos mais abaixo:
            string FirstStartsWithA = list.Find(Test);
            Console.WriteLine($"O primeiro nome que começa com A é: {FirstStartsWithA}");
            // => O primeiro nome que começa com A é: Alex


            // Fazendo o mesmo procedimento com uma expressão lambda, em vez de usar uma função, para achar o que começa com a letra B:
            string FirstStartsWithB = list.Find(x => x[0] == 'B');
            Console.WriteLine($"O primeiro nome que comça com B é: {FirstStartsWithB}");
            // => O primeiro nome que comça com B é: Bob


            // Encontrando o último elemento que começa com a letra A:
            string lastStartsWithA = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"O último nome que começa com a letra A é: {lastStartsWithA}");
            //  => O último nome que começa com a letra A é: Anders


            // Encontrar primeira ou última posição de elemento da lista que satisfaça um predicado:
            int firstPositionNameWithA = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Posição do primeiro nome que começa com A: {firstPositionNameWithA}");
            // => Posição do primeiro nome que começa com A: 3


            int lastPositionNameWithA = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Posição do último nome que começa com A: {lastPositionNameWithA}");
            // => Posição do último nome que começa com A: 6


            // Filtrar a lista com base em nomes que tenham apenas 5 letras:
            List<string> filteredList = list.FindAll(x => x.Length == 5);
            foreach (string name in filteredList)
            {
                Console.WriteLine(name);
                // => Maria Marco
            }


            // Remover elementos da lista

            list.Remove("Bob"); // remove apenas o elemento especificado
            foreach (string name in list) { Console.WriteLine(name); };

            list.RemoveAll(x => x[0] == 'A'); // remove todos os elementos que começam com a letra A
            foreach (string name in list) { Console.WriteLine(name); }; // => 0 - Carlos, 1 - Maria, 2 - Eduardo e 3 - Marco

            // Remover por íncide:
            list.RemoveAt(2); // remove Eduardo
            foreach (string name in list) { Console.WriteLine(name); };

            // Remover os elementos de uma faixa:
            list.RemoveRange(1, 2); // A paertir da posição 1 eu quero remover dois elementos
            Console.WriteLine("-----------------");
            foreach (string name in list) { Console.WriteLine(name); }; // => Carlos

        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}