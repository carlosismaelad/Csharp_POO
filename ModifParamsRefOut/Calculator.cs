using System;


namespace ModifParamsRefOut
{
    public class Calculator
    {
        // USANDO REF
        // public static void Triple(int x) escrevendo desta forma não irá funcionar!
        public static void Triple(ref int x) // x se torna referência para a variável original
        {
            x = x * 3;
        }

        // USANDO OUT
        public static void Multiple(int origin, out int result) // mantemos a variável de origem e guardamos seu resultado na var result
        {
            result = origin * 2;

        }
    }
}