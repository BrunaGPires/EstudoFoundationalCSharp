# Introdução as bibliotecas do .net

### O que é a biblioteca de classes do .net?
- É uma coleção de milhares de classes que contém dezenas de milhares de métodos.
    - Ela inclui a classe Console para desenvolvedores que trabalham em aplicativos de console. A classe Console inclui métodos para operações de entrada e saída, como Write(), WriteLine(), Read(), ReadLine() e muitos outros.
- Uma classe é um container para métodos. 
- Desenvolvedores mantêm os métodos relacionados juntos em uma única classe.
- essas classes e métodos permitem que você crie um tipo específico de aplicativo. Por exemplo, um dos maiores subconjuntos de classes e métodos permite que você crie aplicativos Web dinâmicos. Outro subconjunto de classes e métodos permitem que você acesse um banco de dados.
- Por exemplo, se você deseja ler ou gravar informações de um arquivo ou executar operações de trigonometria ou cálculo, há classes/métodos de uso geral que podem ser usados no código.

### Até mesmo os tipos de dados fazem parte da Biblioteca de Classes do .NET
Na verdade, os tipos de dados em C# (como string e int) são disponibilizados por meio de classes na biblioteca de classes do .NET. A linguagem C# mascara a conexão entre os tipos de dados e as classes do .NET para simplificar seu trabalho. No entanto, nos bastidores, os tipos de dados são implementados como todas as outras classes na Biblioteca de Classes do .NET. Essa conexão fornece suas variáveis cotidianas com métodos internos que podem ser muito úteis.

## Como chamar métodos na Biblioteca de Classes .net?
- Comece digitando o nome da classe. Neste caso, o nome da classe é Console.
- Adicione o operador de acesso de membro, o símbolo ..
- Adicione o nome do método. Neste caso, o nome do método é WriteLine.
- Adicione o operador de chamada do método, que é um conjunto de parênteses ().

Opcionalmente, dependendo de como os desenvolvedores criaram e implementaram o método especificado, você também precisará:
- Passar valores adicionais como parâmetros de entrada.
- Aceitar um valor retornado.

### Métodos com estado vs. sem estado
O termo estado é usado para descrever a condição do ambiente de execução em um momento específico no tempo.

Conforme o código executa linha por linha, os valores são armazenados em variáveis. A qualquer momento durante a execução, o estado atual do aplicativo é a coleção de todos os valores armazenados na memória.

Os **métodos sem estado**, que são os que não dependem do estado atual do aplicativo para funcionar, são implementados para que possam funcionar sem referenciar ou alterar os valores já armazenados na memória. Eles são conhecidos como **métodos estáticos**.

Por exemplo, o método 'Console.WriteLine()' não depende de nenhum valor armazenado na memórioa. Executando sua função e termina ela sem afetar o erado do aplicativo.

**Métodos com estado**, que devem ter acesso ao estado do aplicativo para funcionar corretamente, são constuídos de maneira que os torna dependentes de valores armazenados na memória por linhas de código anteriores já executadas. Ou eles modificam o estado do aplicativo atualizando valores ou armazenando novos valores na memória. Também conhecidos como **métodos de instância**.

Os métodos com estado (instância) controlam seu estado em campos, que são variáveis definidas na classe. Cada nova instância da classe tem sua própria cópia desses campos nos quais o estado é armazenado.

Uma única classe pode dar suporte a métodos com e sem estado. No entanto, quando você precisa chamar métodos com estado, deve primeiro criar uma instância da classe para que o método possa acessar o estado.

### Criar uma intância de uma classe
- Uma instância de uma classe é chamada de  **objeto**.
- Para criar uma instância use o operador 'new'.

``` csharp
Random dice = new Random();
```

O operador new faz várias coisas importantes:

- Primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo objeto com base na classe Random.
- Ele cria o objeto e o armazena no endereço de memória.
- Ele retorna o endereço de memória para que ele possa ser salvo na variável dice.

Desse ponto em diante, quando a variável dice é referenciada, o Tempo de Execução do .NET executa uma pesquisa nos bastidores para dar a ilusão de que você está trabalhando diretamente com o próprio objeto.

### Por que o método Next() é com estado?
``` csharp
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

Para criar a ilusão de aleatoriedade, os desenvolvedores do método Next() decidiram capturar a data e hora até a fração de um milissegundo e usar isso para propagar um algoritmo que produz um número diferente a cada vez. Embora não seja totalmente aleatório, isso é suficiente para a maioria dos aplicativos. O estado capturado e mantido durante o tempo de vida do objeto dice é o valor de semente. Cada chamada subsequente ao método Next() está executando novamente o algoritmo, mas verifica se a semente é alterada para que o mesmo valor não seja (necessariamente) retornado.

### Como é possível determinar se você precisa criar uma instância de uma classe ante de chamar seus métodos?
- Uma abordagem para determinar se um método é um método com ou sem estado é consultar a documentação.


## Retornar valores e parâmetros de entrada de métodos

### Valores retornados

Alguns métodos não retornam um valor quando são finalizados. Eles são denominados métodos nulos.

Outros métodos são projetados para retornar um valor após a conclusão. O valor de retorno é normalmente o resultado de uma operação. Um valor de retorno é a principal maneira de um método se comunicar com o código que o chama.

Um método pode ser projetado para retornar qualquer tipo de dados, até mesmo outra classe. Por exemplo, a classe String tem alguns métodos que retornam uma cadeia de caracteres, um inteiro ou um booleano.

Ao chamar um método que retorna um valor, geralmente você atribui o valor de retorno a uma variável. Dessa forma, é possível usar o valor posteriormente no código.

### Parâmetros de entrada
A informação consumida por um método é chamada de parâmetro. Um método pode usar um ou mais parâmetros para realizar sua tarefa, ou nenhum.

Os parâmetros de entrada podem ser usados para configurar a maneira como o método executa o trabalho ou podem ser operados diretamente.

Os métodos usam uma assinatura de método para definir o número de parâmetros de entrada necessários e o tipo de dados de cada parâmetro.

Os métodos definem os parâmetros de entrada usando um tipo de dados. Não é possível transmitir argumentos de um tipo de dados diferente como parâmetros de entrada para o método e esperar que ele funcione.

Muitas vezes, os termos “parâmetro” e “argumento” são usados de maneira intercambiável. No entanto, “parâmetro” refere-se à variável que está sendo usada no método. O “argumento” é o valor transmitido quando o método é chamado.

### Métodos sobrecarregados
Um método sobrecarregado é definido com várias assinaturas de método. Os métodos sobrecarregados oferecem diferentes maneiras de chamar o método ou diferentes tipos de dados.

- Permite chamar o método com ou sem parâmetros.

Em alguns casos, versões sobrecarregadas de um método são usadas para aceitar um parâmetro de entrada usando diferentes tipos de dados. Por exemplo, o método Console.WriteLine() tem 19 versões sobrecarregadas diferentes. A maioria dessas sobrecargas permite que o método aceite diferentes tipos e faça a gravação das informações especificadas no console

Em outros casos, as versões sobrecarregadas de um método aceitam números diferentes de parâmetros de entrada. Os parâmetros de entrada alternativos podem ser usados para fornecer mais controle sobre o resultado desejado.

# Lógica de decisão

- Os desenvolvedores se referem ao código que implementa caminhos de execução diferentes como branches de código.
- A instrução if usa uma expressão booliana colocada entre parênteses. Se a expressão for verdadeira, o código após a instrução if será executado. Caso contrário, o runtime do .NET ignora o código e não o executa.

### O que é uma expressão booliana?

- Uma expressão booliana é qualquer código que retorna um valor booliano, true ou false.


Outras expressões boolianas simples podem ser criadas usando operadores para comparar dois valores. Os operadores incluem:

- '==', o operador "igual" para testar a igualdade
- '>', o operador "maior que", para testar se o valor à esquerda é maior que o valor à direita
- '<', o operador "menor que", para testar se o valor à esquerda é menor que o valor à direita
- '>=', o operador "maior ou igual a"
- '<=', o operador "menor ou igual a"
- '||', o operador lógico OR -> a expressão à minha esquerda OU a expressão à minha direita precisa ser verdadeira para que toda a expressão booliana seja verdadeira
- '&&', operador lógico AND -> agrega duas expressões de forma que as duas subexpressões devam ser verdadeiras para que toda a expressão seja verdadeira.

## Armazenar e iterar em sequências de dados usando matrizes e foreach

As matrizes em C# permitem armazenar sequências de valores em uma única estrutura de dados.
- Uma única variável que pode conter vários valores.
- Os valores armazenados em uma matriz geralmente estão relacionados entre si.

Neste exercício, você usa matrizes para armazenar e analisar uma sequência de IDs de pedido.

### O que é uma matriz?
- Uma sequência de elementos de dados individuais que pode ser acessada por meio de um único nome de variável.
- Pode usar um índice numérico baseado em zero para acessar cada elemento de uma matriz. 
- Matrizes permitem coletar dados semelhantes, com uma finalidade ou características em comum, na mesma estrutura de dados para facilitar o processamento.

**Declarando uma matriz**
- O operador new cria uma instância de uma matriz na memória do computador que pode conter três valores.
- O primeiro colchetes indica ao compilador que a viriável é uma matriz. O segundo colchetes indica o número de elementos que a matriz conterá.

**Usando propriedade Length da matriz**
- Para determinar o tamanho de uma matriz, usamos a propriedade Length

```csharp
// declarando uma matriz
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
*/

// inicializando uma matriz
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
```

**Executar um loop em uma matriz com foreach**
O foreach fornece uma maneira simples e limpa de iterar através dos elementos de uma matriz.
A instrução foreach processa os elementos da matriz em ordem de índice crescente, começando no índice 0 e terminando no índice Comprimento - 1. Ela usa uma variável temporária para manter o valor do elemento da matriz associado à iteração atual. Cada iteração executará o bloco de código localizado abaixo da declaração foreach.

```csharp
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

O bloco de código que contém Console.WriteLine(name); será executado uma vez para cada elemento da matriz names. Como o runtime do .NET executa um loop em cada elemento da matriz, o valor armazenado no elemento atual da matriz names será atribuído à variável temporária name para facilitar o acesso dentro do bloco de código.

### Convenções de nome de variável

- camelCase
- Descritivos. Exemplo: bool orderComplete;, NÃO bool isComplete;.
- Não usar abreviações

### Outras convenções de nomenclatura

Há outros tipos de constructos que podem ser usados nos aplicativos e muitos deles têm as próprias convenções.
As classes dão suporte a *campos*, que são membros de uma classe que atuam como variáveis, no sentido de que armazenam valores ou, em vez disso, estado. As classes também são compatíveis com *modificadores de visibilidade*, que permitem que alguns valores sejam *privados* ou *públicos*. Um membro *privado* só pode ser referenciado por outros membros na mesma classe. Um membro *público* pode ser referenciado fora da classe. Assim, você pode criar *campos privados* ou *públicos*. Embora você não vá criar classes neste módulo, é importante saber que as convenções de nomenclatura que você acabou de aprender se enquadram em uma estrutura de nomenclatura maior.

### Desenvolver estruturas foreach e if-elseif-else para processar dados de matriz em C#

****Verificação de conhecimentos****

**1. Um desenvolvedor grava um aplicativo que usa um loop `foreach` para iterar por meio de uma matriz que contém 20 elementos. Depois que o aplicativo for concluído, o desenvolvedor verá que a matriz deve ser atualizada para incluir 40 elementos. O aplicativo precisa examinar todos os 40 elementos de matriz. Qual dos itens a seguir descreve a atualização de código necessária?**

() Nenhuma alteração é necessária para o loop `foreach`.

**2. Um desenvolvedor está trabalhando em uma estrutura aninhada `foreach` que é iterada por meio de todas as matrizes de dados de um aplicativo. A primeira matriz contém os nomes dos locais em que amostras de água foram coletadas. As matrizes restantes contêm os resultados de teste para os exemplos coletados de cada local nomeado. Qual das afirmações a seguir sobre como as matrizes devem ser processadas está correta?**

() O loop externo precisa processar a matriz que contém locais, o loop interno precisa processar as matrizes que contêm exemplos.

## Avaliar expressões boolianas para tomar decisões em C# 
- C# tem suporte a uma ampla variedade de operadores, como operadores de igualdade, comparação e booleanos, que individualmente, server para uma finalidade específica ao implementar lógica de decisão.

- Lógica de decisão é usada para estabelecer caminhos alternativos por meio do código, em que a decisão sobre qual caminho seguir se baseia na avaliação de uma expressão.

## O que é uma expressão?
- É qualquer combinação de valores (literais ou variáveis), operadores e métodos que retornar um único valor.
- Instrução são compostas de uma ou mais expressões.
Exemplo o `if` instrução contém uma única expressão que retorna um único valor.
```csharp
if (myName == "Elvis");
```
Nesse caso, ao desenvolver uma instrução de seleção `if`, você usará uma expressão que retorna `true` ou `false`. Se referem a esse tipo de expressão como uma expressão booliana.
As expressões boolianas são importantes porque seu código pode usar essas expressões para decidir qual bloco de código deve ser executado.

## Avaliando igualdade e desigualdade
- Para verificar igualdade é utilizado o operador `==` entre os dois valores que estão sendo verificados. Se os valores forem equivalentes, a expresão retornará `true`.
- Para verificar se dois valores NÃO são iguais é usado o operdaor `!=` de desigualdade entre os valores.

## Avaliar comparações
Ao trabalhar com tipos de dados numéricos, você talvez deseje determinar se um valor é maior ou menor do que outro valor.
- Maior que `>`
- Menor que `<`
- Maior que ou igual a `>=`
- Menor ou igual a `<=`

## Métodos que retornam um valor booleano
Alguns tipos de dados têm métodos que executam tarefas de utilitário bastante úteis. O tipo de dados String tem muitos deles. Vários retornam um valor booleano incluindo Contains(), StartsWith() e EndsWith().
```csharp
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
//True
//False
```

## O que é negação lógica?
Refere-se ao operador !. Quando você coloca o operador `!` antes de uma expressão condicional, ele força seu código a garantir que a expressão seja falsa.
```csharp
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
//False
//True
```

## O que é o operador condicional?
O operador condicional `?:` avalia a expressão booleana e retorna um entre dois resultados possíveis, dependendo se a expressão booleana é avaliada como verdadeira ou falsa. 
- Normalmente chamado de operador condicional ternário.
Exemplo de formato básico:
```csharp
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
```
## Controlar o escopo da variável e a lógica usando blocos de código
Um bloco de código é uma ou mais instruções do c# que definem um caminho de execução. As instruções fora do bloco de código afetam quando, se e com que frequência o bloco é executado em tempo de execução. 
- Blocos normalmente são delimitados por `{}`.

Blocos de código também podem afetar o escopo das variáveis.
O escopo da variável refere-se à visibilidade dela para os demais códigos do seu aplicativo.
Uma variável com escopo local só pode ser acessada dentro do bloco de código no qual ela está definida. Se você tentar acessar a variável fora do bloco de código, obterá um erro do compilador.

**Exemplos:**
```csharp
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");
//error CS0165: Use of unassigned local variable 'value'
```

Inicializando a variável com um valor
```csharp
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);
//Inside of code block: 10
//Outside of code block: 10
```
## Remover blocos de código de instruções if
Se o bloco de código precisar de apenas uma linha, é provável que você não precise definir um bloco formal usando chaves. Embora, tecnicamente, não seja necessário separar o código em várias linhas, agrupar várias instruções em uma só linha pode dificultar a leitura do código.

Remover as chaves conforme descrito acima é uma alteração de estilo que não deve afetar a funcionalidade do código. No entanto, você deve tomar medidas para garantir que essas alterações não afetem negativamente a legibilidade do código.
```csharp
bool flag = true;
if (flag)
    Console.WriteLine(flag);
//True
```

Como a instrução if e a chamada de método para Console.WriteLine() são curtas, você pode se sentir impelido a agrupá-las na mesma linha.
```csharp
bool flag = true;
if (flag) Console.WriteLine(flag);
```

Imagine os dois exemplos de código anteriores aninhados em uma seção maior de código.
```csharp
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
```
