using System;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8.Faça um programa que conte de 1 até 1000 e a cada múltiplo de 3 exiba uma
            mensagem na frente: " – Número múltiplo de 3". */

            for(int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i+" - Número Múltiplo de 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
