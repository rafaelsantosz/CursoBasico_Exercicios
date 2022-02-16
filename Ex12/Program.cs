using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 12.Faça um programa que determine o maior e o menor entre os números lidos.A
            condição de parada é a entrada de um valor 0. */

            List<int> numerosInformados = new List<int>();
            bool continua = true;

            while (continua == true)
            {
                Console.WriteLine("Digite um número: (0 finaliza!)");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    continua = false;
                }
                else
                {
                    numerosInformados.Add(num);
                }
            }

            if (numerosInformados.Count != 0)
            {
                Console.WriteLine("O maior número informado foi: " + numerosInformados.Max());
                Console.WriteLine("E o menor número informado foi: " + numerosInformados.Min());
            }
        }
    }
}
