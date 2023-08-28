using System;

namespace ModifParamsRefOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            // USANDO REF
            int a = 10;
            // Calculator.Triple(a); retornaria o valor da variável local (10)
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            /* O que acontece?
            1- O programa principal cria a variável a e chama a função Triple;
            2- é criado um escopo provisório da função Triple com o parâmetro x valendo 10;
            3- quando executamos x = x * 3, dentro dessa variável x será guardado o resultado (30);
            4- quando a função terminar, a execução volta para o programa principal onde a não terá mudado nada;
            5- por isso precisamos usar o ref junto com o parâmetro da função Triple e ref na 
            chamada da função na classe  principal */

            // USANDO OUT
            int b = 5;
            int multiple;
            Calculator.Multiple(b, out multiple);
            Console.WriteLine(multiple); // retorna 10, ou seja 5 * 2
            /* O que acontece aqui?
            1- O programa principal tem as variáveis b valendo 5 e multiple que não foi iniciada ainda;
            2- quando chamamos a função multiple passando b e o out multiple a função é iniciada;
            3- é criado na memória o escopo da função com a variável origin que será uma cópia de b;
            4- a variável out int result será uma referência para a variável multiple que criamos no programa principal;
            5- o resultado guardado em result é repassado para a nossa variável multiple */



        }
    }
}
