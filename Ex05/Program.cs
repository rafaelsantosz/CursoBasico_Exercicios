using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5.Escreva um programa que receba 4 números e apresente a soma dos números pares e
            depois dos números impares. */

            int somaPares = 0, somaImpares = 0;

            Console.WriteLine("Digite 4 Números:");
            for(int i = 1; i <= 4; i++)
            {
                Console.Write(i + "°: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    somaPares += num;
                }
                else
                {
                    somaImpares += num;
                }
            }

            Console.WriteLine("A soma dos números pares é: "+somaPares);
            Console.WriteLine("A soma dos números ímpares é: "+somaImpares);
        }
    }
}
