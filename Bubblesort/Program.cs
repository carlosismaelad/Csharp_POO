using System;
using System.Globalization;

namespace Bubblesort
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] seq = new int[] { 1, 15, 22, 6, 7, 19, 8, 3, 5, 20 };

            Bubblesort(seq);

            foreach (int numero in seq)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();

        }

        public static void Bubblesort(int[] seq)
        {
            int n = seq.Length;
            bool troca;

            do
            {
                troca = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (seq[i] > seq[i + 1])
                    {
                        Trocar(seq, i);
                        troca = true;
                    }
                }
            } while (troca);
        }

        public static void Trocar(int[] seq, int i)
        {
            int aux = seq[i];
            seq[i] = seq[i + 1];
            seq[i + 1] = aux;

        }
    }
}