/* 

Nullable é um recurso de C# para que dados de tipo valor (structs) possam receber o valor null

Uso comum:
- Campos de banco de dados que podem valer nulo (data de nascimento, algum valor numérico, etc.).
- Dados e parâmetros opcionais.

Métodos:
• GetValueOrDefault()
• HasValue - retorna um boolean (True or False)
• Value (retorn o valor ou lança uma exceção se não houver valor)

*/
using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; Isso gera um erro porque x é do tipo valor (struct) e não pode receber null

            // Para que x possa receber null podemos fazer assim:
            Nullable<double> a = null;

            // ou da forma abaixco, que é mais prática:
            double? x = null;
            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault()); // imprime 0 (valor padrão para double que não recebe nada)
            Console.WriteLine(y.GetValueOrDefault()); // imprime 10 (valorarmazenado em y)

            Console.WriteLine(x.HasValue); // imprime False respondendo que x não possui valor
            Console.WriteLine(y.HasValue); // imprime True confirmando que y possui valor

            if (x.HasValue) // imprime "X is null"
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue) // imprime o valor de y (10)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }



        }
    }
}
