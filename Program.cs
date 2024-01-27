using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// crie um programa que solicite o nome de 10
// alunos, e também sua idade. Ao final mostre 
// UmA lista de alunos.
// use um vetor para o nome e outro para idade.

namespace ExercicioForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int[] idades = new int[10];

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Digite o nome do aluno {0}: ", i + 1);
                nomes[i] = Console.ReadLine();


                Console.WriteLine("Digite a idade do aluno {0}: ", i + 1);
                idades[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Lista de alunos:");

            for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}", nomes[i], idades[i]);
                }

                Console.ReadLine();
            
        }
    }
}
