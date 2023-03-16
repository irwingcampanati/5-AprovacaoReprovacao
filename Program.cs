// Escreva um algoritmo que receba quatro notas de um aluno, calcule e mostre a média aritmética das notas e a mensagem de aprovado ou reprovado, considerando para aprovação média 70.

using System;

namespace AprovacaoReprovacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as 4 notas do aluno que deseja saber se estará aprovado ou não ao final do ano.");

            Console.WriteLine("Primeira nota: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Terceira nota: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quarta nota: ");
            int nota4 = Convert.ToInt32(Console.ReadLine());

            int media = ((nota1 + nota2 + nota3 + nota4) / 4);

            if (media > 70)
            {
                Console.WriteLine("O aluno está aprovado com média igual a: " + media);
            }
            else
            {
                Console.WriteLine("O aluno está reprovado com média igual a: " + media);
            }
        }
    }
}