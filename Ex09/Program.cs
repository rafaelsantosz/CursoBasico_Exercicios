using System;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 9. Faça um programa de conversão de base numérica. O programa deverá apresentar
            uma tela de entrada com as seguintes opções:
            1 – Adição
            2 – Subtração
            3 – Multiplicação
            4 – Divisão
            Informe a opção:
            A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois
            números. Em seguida, o programa deve exibir o resultado da opção indicada pelo
            usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta
            seja “S” ou “s”, deverá voltar ao menu, caso contrário deverá encerrar o programa. */

            bool continuar = true;

            while (continuar==true)
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite dois números:");
                        int numAdc1 = int.Parse(Console.ReadLine());
                        int numAdc2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(numAdc1 + "+" + numAdc2 + " = " + (numAdc1 + numAdc2));
                        break;
                    case "2":
                        Console.WriteLine("Digite dois números:");
                        int numSub1 = int.Parse(Console.ReadLine());
                        int numSub2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(numSub1 + "-" + numSub2 + " = " + (numSub1 - numSub2));
                        break;
                    case "3":
                        Console.WriteLine("Digite dois números:");
                        int numMult1 = int.Parse(Console.ReadLine());
                        int numMult2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(numMult1 + "x" + numMult2 + " = " + (numMult1 * numMult2));
                        break;
                    case "4":
                        Console.WriteLine("Digite dois números:");
                        int numDiv1 = int.Parse(Console.ReadLine());
                        int numDiv2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(numDiv1 + "/" + numDiv2 + " = " + (numDiv1 / numDiv2));
                        break;
                    default:
                        Console.WriteLine("Número não reconhecido!");
                        break;
                }

                Console.WriteLine("Deseja voltar ao menu principal? SIM - S, NÃO - Qualquer Tecla");
                string resposta = Console.ReadLine();
                if (resposta == "S" || resposta == "s")
                {
                    continuar = true;
                    Console.Clear();
                }
                else
                {
                    continuar = false;
                }
            }
        }
    }
}
