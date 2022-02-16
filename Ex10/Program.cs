using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 10.Faça um programa que receba o salário e calcule o imposto de renda devido para cada
            salário informado, se for informado 0 feche o programa. */

            bool continua = true;

            while(continua == true)
            {
                Console.WriteLine("Informe o Salário: (0 encerra!)");
                float salario = float.Parse(Console.ReadLine());

                if (salario <= 1)
                {
                    continua = false;
                }
                else if (salario < 1903.99)
                {
                    Console.WriteLine("Não Paga Imposto!");
                }
                else if (salario < 2826.66)
                {
                    Console.WriteLine("Valor do Imposto: " + (salario * (7.5f / 100)));
                }
                else if (salario < 3751.06)
                {
                    Console.WriteLine("Valor do Imposto: " + (salario * (15.0f / 100)));
                }
                else if (salario < 4664.68)
                {
                    Console.WriteLine("Valor do Imposto: " + (salario * (22.5f / 100)));
                }
                else
                {
                    Console.WriteLine("Valor do Imposto: " + (salario * (27.5f / 100)));
                }
            }
        }
    }
}
