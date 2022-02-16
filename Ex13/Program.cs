using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 13.Faça um programa que calcule um plano de salário de um funcionário da Empresa XYZ,
            onde deve ser informado a quantidade de anos de trabalho e o salário inicial.É regra
            da empresa é aumentar o salário nos 3 primeiros anos em 50 % a cada ano, nos demais
            ela aumenta em 100 % a cada ano trabalhado e a cada 10 anos ela dá um bônus de
            10 % de aumento. */

            Console.WriteLine("Informe a quantidade de anos de trabalho:");
            int anosTrabalho = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o salário: ");
            float salario = float.Parse(Console.ReadLine());

            for(int i = 1; i <= anosTrabalho; i++)
            {
                if (i <= 3)
                {
                    salario += (salario * 50 / 100);
                }

                if(i > 3)
                {
                    salario += salario;
                }

                if(i % 10 == 0)
                {
                    salario += (salario * 10 / 100);
                }
            }

            Console.WriteLine("Novo Salário: " + salario);
        }
    }
}
