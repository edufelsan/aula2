using System;
using System.Drawing;


//Console.WriteLine("Hello, World!");
/*
Console.WriteLine("Aula 2");
Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 12 )
{
    Console.WriteLine("Você pode jogar!");
} else
{
    Console.WriteLine("Você não pode jogar");
}
Console.WriteLine("Idade indicativa 12 anos!");
*/
/*
double investimento;
Console.WriteLine("Aula 2 - Exercício 2");
Console.WriteLine("Digite sua doação: ");
double doacao = Convert.ToDouble(Console.ReadLine());

if (doacao >= 1000)
{
    investimento = doacao * 0.15;
} else
{
    investimento = doacao * 0.05;
}
Console.WriteLine("O valor do investimento: R$" + investimento);
*/
/*
Console.WriteLine("Aula 2 - Exercício 3");
Console.WriteLine("Digite sua idade: ");

int idade = Convert.ToInt32(Console.ReadLine());
if (idade < 16 )
{
    Console.WriteLine("Você não pode votar nem embarcar!");
}else if (idade >= 18 )
{
    Console.WriteLine("Voto obrigatório. Pode embarcar!");
}else
{
    Console.WriteLine("Voto não obrigatório");
}
*/
/*
Console.WriteLine("Aula 2 - Momento Hands On");
// declaração das variaveis

double nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("Média: " + media);

if (media >= 7)
{
    Console.WriteLine("Você foi aprovado com a média: " + media);
}
else if (media < 4)
{
    Console.WriteLine("Você foi reprovado com a média: " + media);
}
else
{
    Console.WriteLine("Você deve fazer a prova final, sua média é: " + media);
}
*/


internal class Program
{
    private static void Main(string[] args)
    {
        double saldo, credito;
        Console.WriteLine("Digite o saldo médio da conta: ");
        saldo = Convert.ToDouble(Console.ReadLine());
        credito = 0.0;
        if (saldo < 200)
        {
            Console.WriteLine("Nenhum crédito");
        }
        else if (saldo <= 400)
        {
            credito = saldo * 0.2;
        }
        else if (saldo <= 600)
        {
            credito = saldo * 0.3;
        }
        else
        {
            credito = saldo * 0.4;
        }

        Console.WriteLine("O seu saldo é de R$ " + saldo);
        Console.WriteLine("Seu crédito é de R$ " + credito);
    }
}