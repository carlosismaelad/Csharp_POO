# Classes, Métodos, Construtores, This, Sobrecarga e Encapsulamento

## Construtor

-   É uma operação especial da classe, que é executada no momento da
    instanciação do objeto

    ### Usos comuns:

-   Iniciar valores dos atributos
-   Permitir ou obrigar que o objeto receba dados / dependências no momento de sua
    instanciação (injeção de dependência)

    ### Mais sobre construtores

-   Se um construtor customizado não for especificado, a classe disponibiliza o
    construtor padrão:
-   Produto p = new Produto();
-   É possível especificar mais de um construtor na mesma classe (sobrecarga)

## Sobrecarga

-   É um recurso que uma classe possui de oferecer mais de uma
    operação com o mesmo nome, porém com diferentes listas de
    parâmetros.

## Palavra this

-   É uma referência para o próprio objeto

    ### Usos comuns:

    -   Diferenciar atributos de variáveis locais (Java)
    -   Referenciar outro construtor em um construtor
    -   Passar o próprio objeto como argumento na chamada de um método ou construtor

## Encapsulamento

-   É um princípio que consiste em esconder detalhes de implementação
    de um componente, expondo apenas operações seguras e que o mantenha
    em um estado consistente.
-   Regra de ouro: o objeto deve sempre estar em um estado consistente, e a
    própria classe deve garantir isso.

    ### Opção 1: implementação manual

    -   Todo atributo é definido como private
    -   Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio
    -   Nota: não é usual na plataforma C#

## Properties

-   São definições de métodos encapsulados, porém expondo uma
    sintaxe similar à de atributos e não de métodos
-   https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
-   Uma propriedade é um membro que oferece um mecanismo flexível para ler,
    gravar ou calcular o valor de um campo particular. As propriedades podem ser
    usadas como se fossem atributos públicos, mas na verdade elas são métodos
    especiais chamados "acessadores". Isso permite que os dados sejam
    acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
    dos métodos.

## Auto Properties

### Propriedades autoimplementadas

-   É uma forma simplificada de se declarar propriedades que não
    necessitam lógicas particulares para as operações get e set.
-   public double Price { get; private set; }

## Ordem sugerida para implementação de membros

-   Atributos privados
-   Propriedades aut´oimplementadas
-   Construtores
-   Propriedades customizadas
-   Outros métodos da classe

## Modificadores e acesso

![Alt text](./assets/image.png)

### Classes

#### Acesso por qualquer classe

-   public class Pro´duct

#### Acesso somente dentro do assembly

-   internal class Product
-   class Product

#### Acesso somente pela classe-mãe

-   private class Product
-   Nota: classe aninhada, por padrão, é private

# Comportamento de memória, Arrays e Listas

## Tipos referência vs. tipos valor

### Classes são tipos referência

-   Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim
    “tentáculos” (ponteiros) para caixas
-   Tipos referência aceitam o valor "null", que indica que a variável aponta pra ninguém.

### Structs são tipos valor

-   A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e
    não ponteiros.

#### É possível criar seus próprios structs

![Alt text](./assets/image-1.png)

![Alt text](./assets/image-2.png)

### Valores padrão

#### Quando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos

-   números: 0
-   bool: False
-   char: caractere código 0
-   objeto: null

#### Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", e o próprio compilador não permite que ela seja acessada.

![Alt text](./assets/image-3.png)

## Desalocação de memória - garbage collector e escopo local

### Garbage collector

-   É um processo que automatiza o gerenciamento de memória de um
    programa em execução
-   O garbage collector monitora os objetos alocados dinamicamente
    pelo programa (no heap), desalocando aqueles que não estão mais
    sendo utilizados.

#### Resumo

-   Objetos alocados dinamicamente, quando não possuem mais referência para eles, serão desalocados pelo garbage collector
-   Variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução (desalocação por escopo)

## Nullable

-   É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null
-   Um nullable não pode ser atribuído para um struct comum

#### Uso comum:

-   Campos de banco de dados que podem valer nulo (data de nascimento, algum valor numérico, etc.).
-   Dados e parâmetros opcionais.

#### • Métodos:

-   GetValueOrDefault
-   HasValue
-   Value (lança uma exceção se não houver valor)

#### Valor default para tipos:

-   int: 0
-   double: 0.0
-   string: null
-   bool: false
-   char: caractere código 0
-   objeto: null

## Operador de coalescência nula

-   Se uma determinada expressão ou variável possuir valor, o seu valor será usado. Caso não tenha atribuímos um valor padrão.
-   Ex:
    ![Alt text](./assets/image.png)
-   y recebe x se x possuir valor, caso x seja null y recebe 0.0

## Vetores

-   Em programação, "vetor" é o nome dado a arranjos unidimensionais
-   Arranjo é uma estrutura de dados:
-   Homogênea (dados do mesmo tipo)
-   Ordenada (elementos acessados por meio de posições)
-   Alocada de uma vez só, em um bloco contíguo de memória

#### Vantagens:

• Acesso imediato aos elementos pela sua posição

#### Desvantagens:

• Tamanho fixo
• Dificuldade para se realizar inserções e deleções

## Modificador de parâmetros: ref e out

### Considerações sobre ref e out

#### Diferença:

-   A variável passada como parâmetro ref DEVE ter sido iniciada
-   A variável passada como parâmetro out não precisa ter sido iniciada
-   Conclusão: ambos são muito similares, mas ref é uma forma de fazer
    o compilador obrigar o usuário a iniciar a variável.
-   Nota: ambos são considerados "code smells" (design ruim) e devem
    ser evitados.

## Boxing e Unboxing

#### Boxing

-   É o processo de conversão de um objeto tipo valor para um objeto
    tipo referência compatível

#### Unboxing

-   É o processo de conversão de um objeto tipo referência para um
    objeto tipo valor compatível

## Sintaxe opcional: laço foreach

-   Usado em muitos casos, talvez até mais que o for simples que vimos anteriormente;

#### O que é o laço foreach?

-   Uma sintaxe opcional e simplificada para percorrer coleções.
-   Quando falamos em coleções estamos nos referindo, de forma geral, a vetores, listas e outros tipos de estruturas de dados;

## Listas

-   A lista é a coleção mais comum e mais utilizada no mercado;

#### Lista é uma estrutura de dados:

-   Homogênea (dados do mesmo tipo);
-   Ordenada (elementos acessados por meio de posições);
-   Inicia vazia, e seus elementos são alocados sob demanda;
-   Cada elemento ocupa um "nó" (ou nodo) da lista;

#### Classe:

-   List

#### Namespace:

-   System.Collections.Generic

#### Vantagens:

-   Tamanho variável
-   Facilidade para se realizar inserções e deleções

#### Desvantagens:

-   Acesso sequencial aos elementos
-   OBS: apesar desta desvantagem as implementações de listas são otimizadas. Desenvolvedores conseguem implementar
    uma lista de forma que o acesso aos elementos dela seja parecido com o acesso aos elementos de um vetor, assim,
    é possível ter um acesso razoavelmente rápido e manter as vantagens de se trabalhar com listas.

## Matrizes

### Checklist

-   Revisão do conceito de matriz
-   Declaração e instanciação
-   Acesso aos elementos / como percorrer uma matriz
-   Propriedade Length, Rank e GetLength
-   Referência: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays

### Definição

-   Em programação, "matriz" é o nome dado a arranjos bidimensionais

#### Arranjo é uma estrutura de dados:

-   Homogênea (dados do mesmo tipo)
-   Ordenada (elementos acessados por meio de posições)
-   Alocada de uma vez só, em um bloco contíguo de memória

#### Vantagens:

-   Acesso imediato aos elementos pela sua posição

#### Desvantagens:

-   Tamanho fixo
-   Dificuldade para se realizar inserções e deleções
