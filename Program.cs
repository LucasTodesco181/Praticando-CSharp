
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


Console.WriteLine("Exercício 3");

int? numeroSecreto = 67;
int tentativas = 3;

Console.WriteLine("Digite um numero e tente acertar: ");
int numero = int.Parse(Console.ReadLine()!);

while (tentativas <=3 )
{
    if (numero == numeroSecreto)
    {
        Console.WriteLine("Parabéns você acertou o número");
        break;
    }

    else
    {
        tentativas--;
        Console.WriteLine($"Você errou, ainda têm {tentativas} tentativa(s)");
        

        if(tentativas == 0)
        {
            Console.WriteLine($"Acabou suas tentativas, o numero secreto era {numeroSecreto} ");
            break;
        }
        Console.WriteLine("Digite outro numero: ");
        numero = int.Parse(Console.ReadLine()!);
        break;
    }
}