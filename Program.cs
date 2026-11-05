
//*Exercicio 1

/*
Console.WriteLine("Exercício 1");

Console.WriteLine("Digite o nome do produto: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite a quantidade comprada do produto: ");
int? quantidade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o preço do produto: ");
decimal preco = decimal.Parse(Console.ReadLine()!);

Console.WriteLine($"O nome do produto é {nome}, você comprou {quantidade} unidade(s) que custam {preco}R$ cada.");


var precoTotal = preco * quantidade;
Console.WriteLine($"O preço total da sua compra é {precoTotal}");

Console.WriteLine("----------------------------------------------------------");
*/


//!-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------



//*Exercico 2

/*
Console.WriteLine("Exercício 2");

Console.WriteLine("Qual o nome do aluno?: ");
string? nomeAluno = Console.ReadLine();

Console.WriteLine("Qual a nota desse aluno?: ");
int? nota = int.Parse(Console.ReadLine()!);

if (nota >= 7 && nota < 10)
{
    Console.WriteLine($"Aluno {nomeAluno} foi aprovado");
}

else if (nota >=5 && nota < 7)
{
    Console.WriteLine($"Aluno {nomeAluno} está de recuperação");
}

else if (nota < 5)
{
    Console.WriteLine($"Aluno {nomeAluno} está reprovado");
}

else
{
    Console.WriteLine( "Nota Invalida");
}
*/


//!------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//*Exercicio 3


// using System.Diagnostics;

// Console.WriteLine("Exercício 3");

// int? numeroSecreto = 67;
// int tentativas = 3;

// Console.WriteLine("Digite um numero e tente acertar: ");
// int numero = int.Parse(Console.ReadLine()!);

// while (tentativas <=3 )
// {
//     if (numero == numeroSecreto)
//     {
//         Console.WriteLine("Parabéns você acertou o número");
//         break;
//     }

//     else
//     {
//         tentativas--;
//         Console.WriteLine($"Você errou, ainda têm {tentativas} tentativa(s)");
        

//         if(tentativas == 0)
//         {
//             Console.WriteLine($"Acabou suas tentativas, o numero secreto era {numeroSecreto} ");
//             break;
//         }
//         Console.WriteLine("Digite outro numero: ");
//         numero = int.Parse(Console.ReadLine()!);
//         break;
//     }
// }

//!------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//*Exercicio 4

// Console.WriteLine("Exercício 4");


// int num1 = 0;
// int num2 =0;

// int somar ( int a, int b)
// {
//     return a + b;
// }

// int mult ( int a, int b)
// {
//     return a * b;
// }

// Console.WriteLine("Digite o primeiro numero");
// num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo numero");
// num2 = int.Parse(Console.ReadLine());

// Console.WriteLine($"O valor da soma dos valores é {somar (num1, num2)}");

// Console.WriteLine($"O valor da multiplicação dos valores é {mult (num1, num2)}");



//*Exercicio 5


// int[] numeros = {8, 9, 10}; 

// double[] notas = new double[3];

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Digite a nota do aluno {i + 1}:");
//     notas[i] = double.Parse(Console.ReadLine());
// }

// foreach (double nota in notas)
// {
//     Console.WriteLine($"Nota: {nota}");
// }

// var media = notas.Average();
// Console.WriteLine($"Média das notas: {media}");

//*Exercicio 6
// List<string> Produtos = new List<string>();

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Digite o nome do produto {i + 1}: ");
//     string produto = Console.ReadLine();
//     Produtos.Add(produto);
// }

// foreach (string produto in Produtos)
// {
//     Console.WriteLine($"Produto: {produto}");
// }

// string produtoBusca;

// Console.WriteLine("Digite o nome do produto a ser encontrado: ");
// produtoBusca = Console.ReadLine();

// if(Produtos.Contains(produtoBusca))
// {
//     Console.WriteLine($"O produto {produtoBusca} está na lista.");
// }
// else
// {
//     Console.WriteLine($"O produto {produtoBusca} não está na lista.");
// }

