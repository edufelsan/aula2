using System;
using System.Drawing;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
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
            /*
            double saldo, credito;
            Console.WriteLine("Digite o saldo médio da conta: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            if(saldo < 200)
            {
                Console.WriteLine("Nenhum crédito");
            } else if(saldo >= 201 && saldo <= 400)
            {
                Console.WriteLine("20% do valor do saldo médio");
            } else if(saldo >= 401 && saldo <=600)
            {
                Console.WriteLine("30% do valor do saldo médio");
            } else
            {
                Console.WriteLine("40% do valor do saldo médio");
            }
            */

            double salario, desconto;
            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            desconto = salario * 0.11;
            
            if(desconto < 720)
            {
                Console.WriteLine("O desconto é de: R$" + desconto);
            } else
            {
                Console.WriteLine("O desconto é de R$720");

            }

        }
    }
}
