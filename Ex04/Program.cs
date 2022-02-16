using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Faça um programa que gera a tabuada do número informado pelo usuário.

            Console.WriteLine("Deseja ver a tabuada de que número?");
            int numeroInformado = int.Parse(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numeroInformado + " x " + i + " = " + (numeroInformado * i));
            }
        }
    }
}
