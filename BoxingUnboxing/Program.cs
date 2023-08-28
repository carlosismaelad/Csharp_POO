using System;

namespace BoxingUnboxing
{
    class Program
    {
        public static void Main(string[] args)
        {

            // BOXING - conversão de um objeto tipo valor para objeto tipo referência:
            int x = 20;
            Object obj = x;

            /* O que fizemos aqui?
            1 - criamos uma "caixinha" ma stack com o valor de x (20);
            2 - Object é um tipo genérico da linguagem C# que é compatível com qualquer outro tipo,
            mas é um tipo referência;
            3 - ao declararmos a variável obj e atribuirmos x a ela será realizado o boxing. Obj será, agora,
            uma referência para um novo objeto que será instanciado no heap.
            4 - É importante entendermos, principalmente se queremos criar um programa com alta performance, que,
            embora essa operação seja permitida ela tem um custo de processamento e memória  */


            // UNBOXING - conversão de um objeto tipo referência para um objeto tipo valor
            int y = (int)obj;

            /* O que fizemos aqui?
            1 - Temos a variável obj que aponta para um objeto no heap e esse objeto é compatível com o tipo int;
            2 - Retornamos essa referência para um objeto tipo valor usando o casting */

        }
    }
}
