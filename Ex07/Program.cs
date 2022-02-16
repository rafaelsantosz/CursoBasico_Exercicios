using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7.Escreva um programa que receba uma quantidade definida pelo usuário de números e
            pegue o maior e o menor número informado e apresente na tela. */

            Console.WriteLine("Digite a quantidade de números que deseja informar: ");
            int quantidadeNumeros = int.Parse(Console.ReadLine());
            int[] numerosInformados = new int[quantidadeNumeros];

            for (int i = 1; i <= quantidadeNumeros; i++)
            {
                Console.Write("Número " + i + ": ");
                numerosInformados[i-1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O maior número informado foi: "+numerosInformados.Max());
            Console.WriteLine("E o menor número informado foi: " + numerosInformados.Min());
        }
    }
}
