using System;

namespace MatrizesIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Criando um arranjo bidimensional. O "," entre os colchestes informa que isso serpa uma matriz: terá linhas e colunas.
            double[,] mat = new double[2, 3]; // informamos quantas linhas e quantas colunas ele terá

            Console.WriteLine(mat.Length); // => 6 elementos no total

            Console.WriteLine(mat.Rank); // => 2 linhas no total

            Console.WriteLine(mat.GetLength(0)); // => 2, informando que a dimensão 0 da matriz tem tamanho 2, ou seja, 2 linhas

            Console.WriteLine(mat.GetLength(1)); // => 3, informando que a dimensão 1 da matriz tem tamanho 3, ou seja, 3 colunas.



        }
    }
}
