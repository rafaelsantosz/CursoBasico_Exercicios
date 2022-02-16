using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Escreva um programa que leia:
            -A quantidade de números que o usuário deseja informar.
            -Leia cada número e informe a média aritmética e a soma deles. */

            int quantidadeNumeros, media, somaTotal = 0;

            Console.WriteLine("Digite a quantidade de números que deseja informar: ");
            quantidadeNumeros = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeNumeros; i++)
            {
                Console.Write("Número "+i+ ": ");
                somaTotal += int.Parse(Console.ReadLine());
            }

            media = somaTotal / quantidadeNumeros;

            Console.WriteLine("A média aritmética dos números informados é "+ media + "!");
            Console.WriteLine("E a soma total: " + somaTotal + "!");
        }
    }
}
